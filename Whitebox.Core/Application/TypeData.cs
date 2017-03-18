﻿using System;

namespace Whitebox.Core.Application
{
    public class TypeData : IApplicationItem
    {
        readonly string _id;
        readonly TypeIdentifier _identity;
        readonly bool _isDisposable;

        public TypeData(string id, TypeIdentifier identity, bool isDisposable)
        {
            if (id == null) throw new ArgumentNullException("id");
            _id = id;
            _identity = identity;
            _isDisposable = isDisposable;
        }

        public string Id
        {
            get { return _id; }
        }

        public bool IsDisposable
        {
            get { return _isDisposable; }
        }

        public TypeIdentifier Identity
        {
            get { return _identity; }
        }
    }
}
