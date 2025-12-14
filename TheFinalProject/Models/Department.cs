using System.ComponentModel.DataAnnotations;

namespace TheFinalProject.Models
{
    /// <summary>
    /// Категория финансовых операций (доходы / расходы)
    /// </summary>
    public class Department
    {
        public int Id { get; set; }

        // Название категории (Еда, Транспорт, Зарплата и т.д.)
        [Required(ErrorMessage = "Название категории обязательно")]
        [StringLength(100, ErrorMessage = "Название не может быть длиннее 100 символов")]
        public string Name { get; set; } = string.Empty;
    }
}
