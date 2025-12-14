using System.ComponentModel.DataAnnotations;

namespace TheFinalProject.Models
{
    /// <summary>
    /// Финансовый счёт пользователя (карта, наличные, вклад и т.п.)
    /// </summary>
    public class Account
    {
        public int Id { get; set; }

        // Название счёта (Наличные, Карта Сбербанк и т.д.)
        [Required(ErrorMessage = "Название счёта обязательно")]
        [StringLength(100, ErrorMessage = "Название не может быть длиннее 100 символов")]
        public string DisplayName { get; set; } = string.Empty;

        // Тип счёта (Банковская карта, Наличные, Вклад)
        [Required(ErrorMessage = "Тип счёта обязателен")]
        [StringLength(100, ErrorMessage = "Тип не может быть длиннее 100 символов")]
        public string Role { get; set; } = string.Empty;

        // Основная категория (необязательно, но сохраняем зависимость)
        [Required(ErrorMessage = "Выберите категорию")]
        [Range(1, int.MaxValue, ErrorMessage = "Выберите категорию")]
        public int DepartmentId { get; set; }
    }
}
