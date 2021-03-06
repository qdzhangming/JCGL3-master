﻿/*******************************************************************************
* Copyright (C) JuCheap.Com
* 
* Author: dj.wong
* Create Date: 09/04/2015 11:47:14
* Description: Automated building by service@JuCheap.com 
* 
* Revision History:
* Date         Author               Description
*
*********************************************************************************/

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using JuCheap.Data.Entity;

namespace JuCheap.Data.Config
{
    /// <summary>
    /// 角色表配置
    /// </summary>
    public class RoleConfig : EntityTypeConfiguration<RoleEntity>
    {
        public RoleConfig()
        {
            ToTable("Roles");
            HasKey(item => item.Id);
            Property(item => item.Id).HasColumnType("varchar").HasMaxLength(20);

            Property(item => item.Name).HasColumnType("nvarchar").IsRequired().HasMaxLength(20);
            Property(item => item.Description).HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            HasMany(x => x.Users).WithMany(x => x.Roles).Map(m =>
            {
                m.ToTable("UserRoles");
                m.MapLeftKey("RoleId");
                m.MapRightKey("UserId");
            });
        }
    }
}
