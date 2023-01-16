namespace choresManagement.Services;

public readonly ChoresRepository _repo;

public ChoresService(ChoresRepository repo)
{
    _repo = repo;
}

internal Chores Create(Chore choreData)