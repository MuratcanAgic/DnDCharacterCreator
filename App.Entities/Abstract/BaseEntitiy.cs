﻿namespace App.Entities.Abstract
{
  public class BaseEntitiy
  {
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
  }
}
