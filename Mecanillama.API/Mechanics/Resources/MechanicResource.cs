﻿using Mecanillama.API.Shared.Resources;

namespace Mecanillama.API.Mechanics.Resources;

public class MechanicResource : PersonResource
{
    public string BusinessOwner { get; set; }
    public string Description { get; set; }
    public long Phone { get; set; }
    
}