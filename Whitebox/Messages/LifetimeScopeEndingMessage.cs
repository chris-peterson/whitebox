﻿using System;

namespace Whitebox.Messages
{
    [Serializable]
    public class LifetimeScopeEndingMessage
    {
        readonly string _lifetimeScopeId;

        public LifetimeScopeEndingMessage(string lifetimeScopeId)
        {
            if (lifetimeScopeId == null) throw new ArgumentNullException("lifetimeScopeId");
            _lifetimeScopeId = lifetimeScopeId;
        }

        public string LifetimeScopeId
        {
            get { return _lifetimeScopeId; }
        }
    }
}
