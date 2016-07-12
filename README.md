# Parallelで文字連結を高速化

やってみたらStringBuilderよりも高速になってしまいました。
が、順序制御はできない（やろうとすると遅くなっちゃう）ので、
順序制御が不要の場合には効果が高い手段になります。

記法はこんな感じです。
Parallel.For(スレッドの開始ID, スレッドの終了ID(実際には終了ID -1), スレッドカウンタ => { スレッド内処理 });

```
        private void ParallelNormalLoop(int threadCount)
        {
            string lines = "";
            DateTime timer = DateTime.Now;

            Parallel.For(0, threadCount, i =>
            {
                string threadLines = "";
                for (long j = 0; j < loopLimit.Value / threadCount; j++)
                {
                    long rowNo = j + (((int)loopLimit.Value / 10) * i);
                    threadLines += string.Format("{0},data{1},{2}{3}", rowNo, rowNo, DateTime.Now, System.Environment.NewLine);
                }
                lock (lines) {
                    lines += threadLines;
                };
            });
            switch(threadCount)
            {
                case 2:
                    txtParallelThread2.Text = ((Double)(DateTime.Now.Ticks - timer.Ticks) / 10000000.0).ToString();
                    break;
                case 4:
                    txtParallelThread4.Text = ((Double)(DateTime.Now.Ticks - timer.Ticks) / 10000000.0).ToString();
                    break;
                case 10:
                    txtParallelThread10.Text = ((Double)(DateTime.Now.Ticks - timer.Ticks) / 10000000.0).ToString();
                    break;
                default: break;
            }
            Update();
        }
```
