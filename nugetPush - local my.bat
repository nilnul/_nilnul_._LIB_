set p=23
set pack=_nilnul_._LIB_.1.0.%p%.nupkg

nuget push -source local %pack%
nuget push -source my %pack%
@pause