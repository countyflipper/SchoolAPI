using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IOrganizationRepository _organizationRepository;
        private IUserRepository _userRepository;
        private ICourseRepository _courseRepository;
        private ICourseSectionRepository _CourseSectionRepository;
        private ISectionEnrollManage _SectionEnrollManage;
        private ISectionAssignRepository _SectionAssign;
        private ICourseManagement _CourseManagement;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IOrganizationRepository Organization
        {
            get
            {
                if (_organizationRepository == null)
                    _organizationRepository = new OrganizationRepository(_repositoryContext);

                return _organizationRepository;
            }
        }

        public IUserRepository User
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_repositoryContext);

                return _userRepository;
            }
        }

        public ICourseRepository Course
        {
            get
            {
                if (_courseRepository == null)
                    _courseRepository = new CourseRepository(_repositoryContext);

                return _courseRepository;
            }
        }

        public ICourseSectionRepository CourseSection
        {
            get
            {
                if (_CourseSectionRepository == null)
                    _CourseSectionRepository = new CourseSectionRepository(_repositoryContext);

                return _CourseSectionRepository;
            }
        }

        public ISectionEnrollManage SectionEnrollManage
        {
            get
            {
                if (_SectionEnrollManage == null)
                    _SectionEnrollManage = new SectionEnrollManageRepository(_repositoryContext);

                return _SectionEnrollManage;
            }
        }

        public ISectionAssignRepository SectionAssign
        {
            get
            {
                if (_SectionAssign == null)
                    _SectionAssign = new SectionAssignRepository(_repositoryContext);

                return _SectionAssign;
            }
        }

        public ICourseManagement CourseManagement
        {
            get
            {
                if (_CourseManagement == null)
                    _CourseManagement = new CourseManagementRepository(_repositoryContext);

                return _CourseManagement;
            }
        }


        public void Save() => _repositoryContext.SaveChanges();
    }
}