﻿using System;
using System.Collections.Generic;
using Merchello.Core.Models;
using Umbraco.Core.Persistence.Repositories;

namespace Merchello.Core.Persistence.Repositories
{
    /// <summary>
    /// Defines the LineItemRepositoryBase class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal interface ILineItemRepositoryBase<T> : IRepositoryQueryable<Guid, T> where T : class, ILineItem
    {
        IEnumerable<T> GetByContainerKey(Guid containerKey);

        void SaveLineItem(LineItemCollection items, Guid containerKey);
        void SaveLineItem(T item); 
    }
}