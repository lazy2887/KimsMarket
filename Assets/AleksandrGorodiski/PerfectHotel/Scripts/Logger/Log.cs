﻿using System;
using UnityEngine;

namespace Game
{
    public static class Log
    {
        public static bool IsLogsEnabled = true;

        public static void Info(object message)
        {
            if (!IsLogsEnabled)
                return;

            Debug.Log(message);
        }

        public static void Exception(Exception exception)
        {
            Debug.LogException(exception);
        }

        public static void Warning(object message)
        {
            Debug.LogWarning(message);
        }

        public static void Error(string error)
        {
            Debug.LogError(error);
        }
    }
}