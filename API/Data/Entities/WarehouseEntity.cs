﻿using System;
using System.Collections.Generic;

namespace API.Data.Entities;

public partial class WarehouseEntity
{
    public int WarehouseId { get; set; }

    public string WarehouseLocation { get; set; } = null!;

    public int WarehouseCapacity { get; set; }

    public int BranchId { get; set; }

    public bool IsDeleted { get; set; } = false;

    public virtual BranchEntity Branch { get; set; } = null!;

    public virtual ICollection<WarehouseItemEntity> WarehouseItemEntities { get; set; } = new List<WarehouseItemEntity>();
}
