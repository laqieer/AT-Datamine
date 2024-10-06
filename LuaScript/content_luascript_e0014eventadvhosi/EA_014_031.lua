Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	
	Suisei = set_chara_unknown()
	character2DFull(Suisei, "Suisei", 101069001 )

end

function Play()
	Play_start(false)

				--//戦闘開始
	-- @星街すいせい	彗星のごとく現れたスターの原石！アイドルＶｔｕｂｅｒの星街すいせいでーす！
	change_face(Suisei,"Smile")
	open_speech_window("CHRNAME_SUISEI",Suisei , nil)
	message("EA_014_0310002")
	--close_speech_window()

				--//戦闘前に名乗りを上げるように
	-- @星街すいせい	すいちゃんは～？	
	--open_speech_window("PLAYERNAME_NOIR", , nil)
	message("EA_014_0310004")
	--close_speech_window()

-- 選択1回目
    MA_01A109_22_select1()
 
    open_select_window_tag(Noir, "Normal", "EA_014_0310006", "EA_014_0310007")  -- 選択肢表示
 
    if is_select(1) then            -- 1番目の選択肢を選んだ場合
        MA_01A109_22_select1_1()
 
    elseif is_select(2) then        -- 2番目の選択肢を選んだ場合
        MA_01A109_22_select1_2()
 
    end
    MA_01A109_22_end()
 
end
 
function MA_01A109_22_select1()
 
end
 
function MA_01A109_22_select1_1()
 
-- ---選択肢1

	--//分岐1
				--//１を選択
	-- @ノワール	今日もかわいいー！	
	change_face(Noir2,"Smile")
	open_speech_window("PLAYERNAME_NOIR",Noir2,nil)
	message("EA_014_0310010")
	close_speech_window()

	-- @星街すいせい	ありがとう！	
	open_speech_window("CHRNAME_SUISEI",Suisei , nil)
	message("EA_014_0310011")
	close_speech_window()
 
      -- ---選択肢1ここまで
end
 
 
function MA_01A109_22_select1_2()
 
-- ---選択肢2

	--//分岐2
				--//２を選択
	-- @ノワール	？えっと…歌の応援ありがとう力が湧いてくるよ！	
	open_speech_window("PLAYERNAME_NOIR",Noir2,nil)
	message("EA_014_0310014")
	close_speech_window()

	-- @星街すいせい	頑張れー！	
	change_face(Suisei,"Smile")
	open_speech_window("CHRNAME_SUISEI",Suisei , nil)
	message("EA_014_0310015")
	close_speech_window()
 
    -- ---選択肢2ここまで
end

 
function MA_01A109_22_end()

				
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	character2DFull_Preload(Suisei, "Suisei", 101069001)
end
