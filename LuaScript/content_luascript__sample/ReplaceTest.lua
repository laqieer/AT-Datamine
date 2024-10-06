Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_area_scene(100011) -- 教室
	
	setup2D_GendaiPlayer()
	
	
	MAIN_CAMERA = set_camera({1.492, 1.869, -2.837,   13.47999, 312.6548, 0,   21})
	

end

-- 数値を強制的に文字列に変える。
function str(x)
	return x .. ""
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)
	
	open_speech_window("PLAYERNAME_GENDAI", GendaiPlayer)
	message_direct("仮メッセージ<br>現代編主人公の名前は「<%player>」です")
	close_speech_window()
	
	open_narration_window()
	message_direct("LockTitle.Test3の<br>置換前のテキストを表示します")
	
	message("LockTitle.Test3")
	
	message_direct("置換後のテキストを表示します")
	
	
	
	-- common.xlsmの CHRNAME_GUINEVERE を取ってくる
	local charaname = get_message_text("CHRNAME_GUINEVERE")
		
	-- 数値を文字に置き換えるテスト。別にやらなくても大抵は自動的に数値に変換される
	local level = str(2)
	
	message_replace("LockTitle.Test3", charaname, level)
	
	message_direct("直接テキスト指定版<br>message_replace_direct()をテストします")
	
	message_replace_direct("<%1>との親密度はLevel<%2>", charaname, level)
	
	
	message_direct("終了します")
	close_speech_window()
	
	
	
	Play_end(true)
end

