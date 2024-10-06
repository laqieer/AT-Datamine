Include("content_luascript_system", "LuaCommonPack")

-- アセットなどを読み込む
function Load()
end

-- シーケンスの実行
function Play()
	wait_time(60.0)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
