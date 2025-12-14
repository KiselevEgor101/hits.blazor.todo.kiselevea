using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheFinalProject.Data;

namespace TheFinalProject.Models
{
    /// <summary>
    /// Финансовая операция (доход / расход / перевод)
    /// </summary>
    public class Transaction
    {
        public int Id { get; set; }

        // Категория операции (например: Еда, Транспорт, Зарплата)
        [Required(ErrorMessage = "Выберите категорию")]
        [Range(1, int.MaxValue, ErrorMessage = "Выберите категорию")]
        public int DepartmentId { get; set; }

        // Счёт (карта, наличные, вклад и т.д.)
        [Required(ErrorMessage = "Выберите счёт")]
        [Range(1, int.MaxValue, ErrorMessage = "Выберите счёт")]
        public int AccountId { get; set; }

        // Тип операции: "Доход", "Расход", "Перевод"
        [Required(ErrorMessage = "Выберите тип операции")]
        public string OperationType { get; set; } = string.Empty;

        // Сумма операции
        [Required(ErrorMessage = "Укажите сумму")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Сумма должна быть больше нуля")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        // Описание операции
        [StringLength(500)]
        public string? Description { get; set; }

        // Дата финансовой операции
        public DateTime Date { get; set; } = DateTime.UtcNow;

        // Используется при переводах между категориями/счетами
        public int? TargetDepartmentId { get; set; }
    }
}
