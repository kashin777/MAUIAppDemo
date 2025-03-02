﻿using MauiAppDemo.Models;

namespace MauiAppDemo.Services;

public interface IMauiAppDemoService
{
    public MauiAppDemoDbContext DBContext { get; }

    public User LoginUser { set; get; }
}
