﻿// Copyright (c) 2014 Thong Nguyen (tumtumtum@gmail.com)

namespace Platform
{
	public interface IKeyedValued
		: IKeyed, IValued
	{
	}

	public interface IKeyedValued<K, V>
		: IKeyed<K>, IValued<V>
	{
	}
}
