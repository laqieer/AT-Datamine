Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	Suisei = set_chara_unknown()
	character2DFull(Suisei, "Suisei", 101069001 )

end

function Play()
	Play_start(false)
	
	
	-- @星街すいせい	みんな、お疲れ様♪
	change_face(Suisei, "Smile")	
	open_speech_window("CHRNAME_SUISEI",Suisei , nil)
	message("EA_014_0210003")
	close_speech_window()

					
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Suisei, "Suisei", 101069001)
end
