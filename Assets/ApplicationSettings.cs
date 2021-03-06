﻿using System.Collections;
using UnityEngine;

namespace UnityStar.Assets
{
    public static class ApplicationSettings
    {
        public static int MAX_SONG_SCORE = 10000;
        public static int MAX_SONG_LINE_BONUS = 1000;
        public static string CurrentSongFile { get; set; }
    }
}