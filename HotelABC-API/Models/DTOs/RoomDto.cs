﻿using HotelABC_API.Models.Domain;

namespace HotelABC_API.Models.DTOs
{
    public class RoomDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Characteristics { get; set; }

        public string? Image { get; set; }
    }
}
