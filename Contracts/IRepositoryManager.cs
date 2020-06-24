namespace Contracts
{
    public interface IRepositoryManager
    {
        IOrganizationRepository Organization { get; }
        IUserRepository User { get; }
        ICourseRepository Course { get; }
        ICourseSectionRepository CourseSection {get;}
        ISectionEnrollManage SectionEnrollManage { get; }

        ISectionAssignRepository SectionAssign { get; }

        ICourseManagement CourseManagement { get; }

        void Save();
    }
}