namespace Landis.Library.AgeOnlyCohorts
{
    /// <summary>
    /// A disturbance that considers cohorts individually, independent of
    /// each other.
    /// </summary>
    public interface ICohortDisturbance
        : IDisturbance
    {
        /// <summary>
        /// Determines if a cohort is damaged by the disturbance.
        /// </summary>
        bool MarkCohortForDeath(ICohort cohort);
    }
}
