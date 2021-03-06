﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TobesMediaCore.Data.Media;

namespace TobesMediaServer.MediaPipeline
{
    public interface IMediaService
    {
        public Task ProcessMediaAsync(MediaFile media, bool restore);
    }
}
