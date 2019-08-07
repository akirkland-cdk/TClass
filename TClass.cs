using System;
using System.Collections.Generic;

   public class TClass
    {
        public TResult Result { get; set; }
        public Exception Error { get; set; }        
    }
    public class TClassException : Exception
    {
        public TClassException(dynamic json)
                : base("Custom Error Message")
        {
            _Message = json.message;
        }

        public override string Message => _Message;

        private readonly string _Message;
    }

    public enum TResult
    {
        OnError = 0,
        Success = 1,
    }

    public class TExMsg
    {
        //public static Dictionary<int, TClassException> TExMsgDic;
        public TExMsg()
        {
            TExMsgDic = new Dictionary<int, TClassException>()
        {
                {1, new TClassException(new { message = "This company already exists!" })},
                {2, new TClassException(new { message = "Unknown Error" })}
        };
        }

        public Dictionary<int, TClassException> TExMsgDic { get; private set; }
}

