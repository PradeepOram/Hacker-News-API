﻿using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IStoryServices
    {
        Task<PageResponse> GetStories(int page,int pageSize);
    }
}
