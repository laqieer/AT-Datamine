--[[
	Advのムービー処理
]]
movie_director = nil

loadedMovieName = nil

moviePlaySignal = nil
-- ムービーファイルのロード
--  movieFileName = ムービーファイル名
--  subtitlesBaseName = 字幕データのフォルダ名
function movie_load(movieFileName, subtitlesBaseName)
	loadedMovieName = movieFileName
	load_timeline("content_adv_timeline_timelinemovie_"..string.lower(movieFileName).."_scene", "TLM_"..movieFileName);
end

function movie_load_preload(movieFileName, subtitlesBaseName)
	system.PreDownloadRequest("ADV_"..movieFileName)
	system.PreDownloadRequest("content_adv_timeline_timelinemovie_"..string.lower(movieFileName).."_scene")
end

-- ムービーオブジェクトのアクティブ指定
--  active = アクティブ状態
function movie_set_active(active)
end

-- 直前にロードされているムービーの再生
function movie_play()
	movie_play_assign(loadedMovieName)
end

-- 
function movie_play_assign(movieName)
	if moviePlaySignal ~= nil and moviePlaySignal.IsProccessing() then
		resume_timeline();
	else
		moviePlaySignal = play_timeline_async("TLM_"..movieName, false, nil)
	end
end

-- ムービーの停止。停止した場合は再度ロードから行わないと再生されない。
function movie_stop()
	stop_timeline()
end

-- ムービーの一時停止。movie_playで再開する
function movie_pause()
	pause_timeline()
end

-- ロードされているムービーの再生完了待ち
function movie_wait_playing()
	while moviePlaySignal.IsProccessing() do
		coroutine.yield()
	end
	moviePlaySignal = nil

	if TextBox ~= nil then
		-- テキストボックスのOut演出中に次のコマンド実行をすると表示が制御がおかしくなるためここで演出を待つ
		local waitSignal = TextBox.WaitPlayingTween()
		while waitSignal.IsProccessing() do
			coroutine.yield()
		end
	end
end

-- プレファブのみで再生するムービー処理
movie_director = nil

-- ムービーファイルのロード
--  movieFileName = ムービーファイル名
--  subtitlesBaseName = 字幕データのフォルダ名
function simple_movie_load(movieFileName, subtitlesBaseName, existH265, width, height, verticalFit)
	if movie_director == nil then
		movie_director = system.LoadMovieDirector()
		while movie_director.IsProccessing() do
			coroutine.yield()
		end
	end

	if width == nil then
		width = 1440
	end
	if height == nil then
		height = 720
	end
	if verticalFit == nil then
		verticalFit = false
	end

	local signal = movie_director.LoadMovie(movieFileName, subtitlesBaseName, existH265, width, height, verticalFit)
	while movie_director.IsProccessing() do
		coroutine.yield()
	end
end

function simple_movie_load_preload(movieFileName, subtitlesBaseName, existH265, width, height, verticalFit)
	system.PreDownloadMovieRequest(movieFileName, existH265)
	system.PreLoadRequest("ui_page_adv")
	system.PreLoadRequest(system.ResouceDataUtility.GetMovieSubtitleAssetBundleName(subtitlesBaseName))
	system.PreDownloadRequest(system.ResouceDataUtility.GetMovieTextAssetBundleName(subtitlesBaseName))
end

-- ムービーオブジェクトのアクティブ指定
--  active = アクティブ状態
function simple_movie_set_active(active)
	if movie_director ~= nil then
		movie_director.SetActive(active)
	end
end

-- ロードされているムービーの再生
function simple_movie_play()
	if movie_director ~= nil then
		movie_director.Play()
	end
end

-- ムービーの停止。停止した場合は再度ロードから行わないと再生されない。
function simple_movie_stop()
	if movie_director ~= nil then
		movie_director.Stop()
	end
end

-- ムービーの一時停止。movie_playで再開する
function simple_movie_pause()
	if movie_director ~= nil then
		movie_director.Pause()
	end
end

-- ロードされているムービーの再生完了待ち
function simple_movie_wait_playing()
	if movie_director ~= nil then
		while movie_director.IsProccessing() do
			coroutine.yield()
		end
	end
end

-- 外部から呼ばれる関数 UiHeaderFooterで呼ばれる
function simple_movie_set_playback_speed(speed)
	if movie_director ~= nil then
		movie_director.SetPlaybackSpeed(speed)
	end
end