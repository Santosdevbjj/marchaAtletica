using System;

namespace TrainingService.Models
{
    /// <summary>
    /// Entidade que representa uma sessão de marcha (treino ou competição).
    /// </summary>
    public class TrainingSession
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        // Identificador do atleta (pode ser FK para tabela de usuários / atletas)
        public string AthleteId { get; set; } = default!;

        // Distância em km: 3,5,10,20,35,50, ou outra distância de treino
        public double DistanceKm { get; set; }

        // Tempo gasto (em segundos) — armazenamos como TimeSpan em mapeamento
        public TimeSpan Duration { get; set; }

        // Data e hora local do treino/competição
        public DateTime OccurredAt { get; set; }

        // Se foi uma competição (true) ou treino (false)
        public bool IsCompetition { get; set; }

        // Temperatura no dia (graus Celsius)
        public float TemperatureC { get; set; }

        // Observações (hidratação, condições, etc.)
        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
