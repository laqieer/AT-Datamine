
uiEffectTimelineLoadedList = {}

-- 汎用UIエフェクトロード処理
-- assetbundleName = ロードするアセットバンドル名
-- fileName = UIエフェクトのファイル名
-- timelineAssetbundleName = 一緒にロードするタイムラインアセットバンドル名　nilの場合はロードされない
-- timelineTags = ロードするタイムラインの登録タグ（リスト指定も可) 他とかぶってはいけないのでui_effect_指定名で登録する
-- timelineFileNames = ロードするタイムラインのファイル名（リスト指定も可)
-- rootName = どこのルートに配置するか
function load_ui_effect(assetbundleName, fileName, timelineAssetbundleName, timelineTags, timelineFileNames, rootName)
	local uiEffect = nil
	if rootName != nil and rootName == "Root" then
		uiEffect = system.LoadUIToRoot(assetbundleName, fileName, -1)
	elseif rootName != nil and rootName == "Back2D" then
		uiEffect = system.LoadUIToBack(assetbundleName, fileName, -1)
	else
		uiEffect = system.LoadUI(assetbundleName, fileName, -1)
	end
	UiLoadList[#UiLoadList + 1] = uiEffect

	if timelineAssetbundleName ~= nil then
		-- 一緒にロードしておくタイムライン
		if type(timelineTags) == "table" then
			for i = 1, #timelineTags do
				local timelineTag = "ui_effect_"..timelineTags[i]
				uiEffectTimelineLoadedList[timelineTag] = #UiAssetLoadList + 1
				UiAssetLoadList[#UiAssetLoadList + 1] = system.LoadStackObject(timelineTag, timelineAssetbundleName, timelineFileNames[i])
			end
		else
			local timelineTag = "ui_effect_"..timelineTags
			uiEffectTimelineLoadedList[timelineTag] = #UiAssetLoadList + 1
			UiAssetLoadList[#UiAssetLoadList + 1] = system.LoadStackObject(timelineTag, timelineAssetbundleName, timelineFileNames)
		end
	end

	return uiEffect
end

function load_ui_effect_preload(assetbundleName, fileName, timelineAssetbundleName, timelineTags, timelineFileNames, rootName)
	system.PreLoadRequest(assetbundleName)
	system.PreLoadRequest(timelineAssetbundleName)
end


-- 汎用UIエフェクト再生処理
-- uiEffect = load_ui_effectで返却されるuiEffectのID
-- playObjectName = 再生をかけるタイムラインを持っているエフェクトのオブジェクト名(データ作成者に確認)
-- playTimelineTag = 一緒にロードしたタイムラインを再生する場合に登録タグを指定 nilの場合はデフォルトのものを再生
-- isWait = 再生終了を待つか
function play_ui_effect(uiEffect, playObjectName, playTimelineTag, isWait)
	uiEffect.SetActive(playObjectName, true)

	if playTimelineTag ~= nil then
		uiEffect.SetTimeline(playObjectName, "ui_effect_"..playTimelineTag)
	end

	uiEffect.StartTimeline(playObjectName)
	if isWait then
		wait_ui_effect(uiEffect, playObjectName)
	end
end

-- 汎用UIエフェクト再生終了待ち
-- uiEffect = load_ui_effectで返却されるuiEffectのID
-- playObjectName = 再生をかけるタイムラインを持っているエフェクトのオブジェクト名(データ作成者に確認)
function wait_ui_effect(uiEffect, playObjectName)
	uiEffect.StartTimeline(playObjectName)
	while uiEffect.WaitForTimeline(playObjectName) do
		coroutine.yield()
	end
end

-- UITimelineControllerを使用したINアニメーションの再生
-- uiEffect = load_ui_effectで返却されるuiEffectのID
-- playObjectName = 再生をかけるタイムラインを持っているエフェクトのオブジェクト名(データ作成者に確認) defaultは「TimelineController」
-- animeKey = INタイプでかつInの名前になっていない場合に指定をする
function play_ui_timeline_controller_in(uiEffect, playObjectName, animeKey)
	if playObjectName == nil then
		playObjectName = "TimelineController"
	end
	return uiEffect.PlayUITimelineControllerInAnimation(playObjectName, animeKey)
end

-- UITimelineControllerを使用したOUTアニメーションの再生
-- uiEffect = load_ui_effectで返却されるuiEffectのID
-- lastActive = OUTアニメーション再生後のオブジェクトのアクティブ状態を指定する
-- playObjectName = 再生をかけるタイムラインを持っているエフェクトのオブジェクト名(データ作成者に確認) defaultは「TimelineController」
-- animeKey = OUTタイプでかつOutの名前になっていない場合に指定をする
function play_ui_timeline_controller_out(uiEffect, lastActive, playObjectName, animeKey)
	if playObjectName == nil then
		playObjectName = "TimelineController"
	end
	return uiEffect.PlayUITimelineControllerOutAnimation(playObjectName, lastActive, animeKey)
end

-- 汎用UIエフェクトの破棄
-- uiEffect = load_ui_effectで返却されるuiEffectのID
-- timelineTags = 破棄するタイムラインの登録タグ（リスト指定も可) 他とかぶってはいけないのでui_effect_指定名で登録する
function unload_ui_effect(uiEffect, timelineTags)
	if uiEffect ~= nil then
		local removePos = 0
		for i = 1, #UiLoadList do
			if UiLoadList[i] == uiEffect then
				removePos = i
				break
			end
		end
		if removePos > 0 then
			table.remove(UiLoadList, removePos)
		end
		uiEffect.Empty(true)
	end	

	if timelineTags ~= nil then
		-- 一緒に破棄しておくタイムライン
		if type(timelineTags) == "table" then
			for i = 1, #timelineTags do
				local timelineTag = "ui_effect_"..timelineTags[i]
				table.remove(UiAssetLoadList, uiEffectTimelineLoadedList[timelineTag])
				system.RemoveStackObject(timelineTag)

				local removeIndex = uiEffectTimelineLoadedList[timelineTag]
				for k, v in pairs(uiEffectTimelineLoadedList) do
					if removeIndex < v then
						uiEffectTimelineLoadedList[k] = v - 1;
					elseif removeIndex == v then
						uiEffectTimelineLoadedList[k] = nil
					end
				end
			end
		else
			local timelineTag = "ui_effect_"..timelineTags
			table.remove(UiAssetLoadList, uiEffectTimelineLoadedList[timelineTag])
			system.RemoveStackObject(timelineTag)

			local removeIndex = uiEffectTimelineLoadedList[timelineTag]
			for k, v in pairs(uiEffectTimelineLoadedList) do
				if removeIndex < v then
					uiEffectTimelineLoadedList[k] = v - 1;
				elseif removeIndex == v then
					uiEffectTimelineLoadedList[k] = nil
				end
			end
		end
	end
end