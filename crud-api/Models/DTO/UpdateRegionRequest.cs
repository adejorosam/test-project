﻿using System;
namespace crud_api.Models.DTO
{
    public class UpdateRegionRequest
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Area { get; set; }

        public double Lat { get; set; }

        public double Long { get; set; }

        public long Population { get; set; }

        public string Code { get; set; }
    }
}

