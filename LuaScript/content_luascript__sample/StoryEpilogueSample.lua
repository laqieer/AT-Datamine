-- ストーリエピローグ用ダミースクリプト
Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","ADVSmallPack")

function Load()
	load_image("SE10102015", "content_still_10102015_image", "101020150_StillImage")
end

function Play()
	StartPlay()

	--エピローグデモ


	
	-- キャラ別スチル画像表示
	show_image("SE10102015", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)

	-- 待ち
	wait_time(10.0)

	-- クリア後機能解放ダイアログ
	popup = system.CreateSystemPopup();
	local msg = "機能「ストーリーチャート」が解放されました。"
	signal = popup.OpenMediumDirect( "",msg )			-- TextTagで行う場合はOpenMedium(tag,tag)
	while signal.IsProccessing() do
		coroutine.yield()
	end

	-- 待ち
	wait_time(2.0)

	-- 引継ぎ要素説明ダイアログ
	msg = "周回プレイの特典として、" ..
		  "クリア時のデータを一部引き継いで最初からストーリーを始めることができます。\n" ..
		  "引き継がれる要素は次の通りです。\n" ..
		  "一部の大事なアイテムを除く全アイテム\n" ..
		  "パーソナルパラメータ\n" ..
		  "キズナアビリティの効果\n" ..
		  "各コンテンツの解放状況\n"
	signal = popup.OpenMediumDirect( "", msg )
	while signal.IsProccessing() do
		coroutine.yield()
	end

	-- 待ち
	wait_time(2.0)

	-- 周回プレイ説明ダイアログ
	msg =	"アスタータタリクスには" ..
			"複数のストーリー分岐とエンディングが用意されています。\n" ..
			"物語を繰り返すことであなたがまだ知らない結末にきっと辿り着けるでしょう。\n"
	signal = popup.OpenMediumDirect( "", msg )
	while signal.IsProccessing() do
		coroutine.yield()
	end

	-- 待ち
	wait_time(2.0)


	EndPlay()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する


end
