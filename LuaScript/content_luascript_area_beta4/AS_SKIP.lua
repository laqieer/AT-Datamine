-- エリアイベント開始用処理スキップスクリプト
-- ※マスターへの登録上スクリプトの指定が必要だが何も処理させずにすぐに終了させたいときに利用

function Load()

end

function Play()

end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
