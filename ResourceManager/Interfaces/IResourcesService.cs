﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainEntities;

namespace Interfaces
{
    public interface IResourcesService
    {
        List<Resource> GetAllResources();
        bool DeleteSingle(Resource resource);
        bool DeleteList(List<Resource> resources);
    }
}
