-- 増援用ダミースクリプト
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")
disableTextBox = true

function Load()
	Load_common(false)

end

function Play()
	Play_start(false)

	show_current_script()	-- デバッグモード時のみ、再生したスクリプトIDを表示する

	sortie_troops(3, 2)	-- ここの()内に増援パラメータを記載する
	wait_seq()

	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
