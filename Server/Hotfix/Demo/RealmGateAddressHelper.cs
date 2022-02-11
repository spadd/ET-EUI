using System.Collections.Generic;


namespace ET
{
	public static class RealmGateAddressHelper
	{
		public static StartSceneConfig GetGate(int zone,long accountId)
		{
			List<StartSceneConfig> zoneGates = StartSceneConfigCategory.Instance.Gates[zone];
			
			// int n = RandomHelper.RandomNumber(0, zoneGates.Count);
			
			// 根据 hashcode 对 网关数量取模
			int n = accountId.GetHashCode() % zoneGates.Count;

			return zoneGates[n];
		}
	}
}
