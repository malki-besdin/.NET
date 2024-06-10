using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Organization.Core.Entities
{
    public enum NameRole
    {
        SoftwareDevelopers,
        DataAnalyst,
        DataScientist,
        QASoftwareTester,
        InformationSecurityCyber,
        ProductManager,
        ProductMarketing,
        ProductAnalyst
    }
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public bool Management { get; set; }
        public NameRole NameOfRole { get; set; }
        public DateTime DateOfEntry { get; set; } //חייב להיות שווה או מאוחר מתאריך תחילת עבודה
    }
}