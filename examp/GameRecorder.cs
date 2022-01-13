using System;
using System.Collections.Generic;
using System.Text;

namespace examp
{
    class GameRecorder
    {
        public event EventHandler<GameEnevtArgs> GameRecorded;
        public void Record(Game game)
        {
            Console.WriteLine("recording...");
            OnGameRecord(game);
        }
        public void OnGameRecord(Game game)
        {
            GameRecorded?.Invoke(this, new GameEnevtArgs() { Game=game});
        }
    }
    class GameEnevtArgs : EventArgs
    {
        public Game Game { get; set; }
    }
}
