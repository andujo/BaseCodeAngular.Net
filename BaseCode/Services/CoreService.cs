using System.Threading.Tasks;
using AutoMapper;
using Model.Dto;
using Model.Repository;

namespace BaseCode.Services;
public interface ICoreService
{
	Task<CoreDto> GetCore(int id);
}

public class CoreService : ICoreService
{

	private readonly ICoreRepository _coreRepository;
    private readonly IMapper _mapper;

    public CoreService(ICoreRepository coreRepository, IMapper mapper)
	{
		_coreRepository = coreRepository;
        _mapper = mapper;
    }
	public async Task<CoreDto> GetCore(int id)
	{
		var core = await _coreRepository.GetCore(id);

		return _mapper.Map<CoreDto>(core);
	}
}