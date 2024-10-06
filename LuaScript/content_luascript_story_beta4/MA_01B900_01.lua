-- このluaスクリプトは、MA_01B900_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
-- ▼直接出力
se_play("SE_ADV_MA_01B900_17_DeepWater_loop")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)
	Actor001 = InitializeCharacter_2DOnly("101067","001","101067001")
	Actor002 = InitializeCharacter_2DOnly("101021","003","101021003")
	Actor003 = InitializeCharacter_2DOnly("101056","001","101056001")
	template1()
end

function Play()
	StartPlay()

	change_face(Actor001,"Sad")

	--★★ニニアン★★:私の犯した咎は<br>王家の血を穢しました
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B900_010002")


	--★★ニニアン★★:穢れた血は今、アーサーの内にある…<br>時が至れば彼は大災と成り果てるやもしれない
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B900_010004")


	--★★ブルーノ★★:…やもしれぬ、とは？
	Talk(Actor002,"CHRNAME_BRUNO","speech","L","MA_01B900_010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ニニアン★★:………継承者の選択が分かれ道です<br>穢れし血がアーサーを災いの王とするか、否か
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B900_010007")


	--★★ペレス★★:継承者が<br>誰とGSを果たすか──
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010008")


	--★★ペレス★★:…その選択により<br>アーサーの運命も決まるということですな
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010010")


	--★★ニニアン★★:ぺレス…聖杯城の主であるあなたに<br>恥を承知で申し上げます
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B900_010011")


	--★★ニニアン★★:いずれにせよこの歴史における人間は<br>聖杯の奇跡に頼らざるを得なくなる
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B900_010012")


	--★★ニニアン★★:巫女の力で継承者を聖杯へと導き<br>彼らに聖域化の手ほどきを願えますか…？
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B900_010013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ペレス★★:…大恩ある妖精ニニアン様<br>それではこちらも申し上げさせていただきます
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010014")

	change_face(Actor003,"Sad")

	--★★ペレス★★:継承者を聖杯へと導くか否か<br>それもまた継承者自身の選択次第でございます
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010015")

	change_face(Actor001,"Surprise")

	--★★ニニアン★★:なぜです…？誰が継承者の劔となろうが<br>世界救済以上に優先すべきことなどありますか？
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B900_010017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ペレス★★:ブルーノ卿の子らの未来です
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010019")


	--★★ブルーノ★★:…ぺレス王
	Talk(Actor002,"CHRNAME_BRUNO","speech","L","MA_01B900_010020")


	--★★ペレス★★:ノワール殿、ランスロット殿が揃って<br>一千年の孤独を背負わねばならぬこととなれば
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010021")


	--★★ペレス★★:我ら家族──銀卓騎士団はそれを引き留め<br>たとえバルバロイとしてでも生かす道を選びます
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010022")

	open_cutin(2,1)
	on_cutin(1,Actor001,"Surprise")
	on_cutin(2,Actor002,"Surprise")
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
	close_cutin()

	--★★ペレス★★:恥を承知で申し上げます
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010024")


	--★★ペレス★★:儂と我が家族はみな狂忘症に侵され既に末期…<br>聖域化された世界では生きていけませぬ
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ペレス★★:バルバロイとなり果てる家族を<br>永劫生かし続けたい
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010026")


	--★★ペレス★★:ノワール殿とランスロット殿を宿命から解放し<br>永遠の寂寥から救い出したい
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010027")

	change_face(Actor001,"Normal")

	--★★ニニアン★★:…あの子らが人として<br>騎士としての生涯を願ってもですか？
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B900_010029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ニニアン★★:世界すべてを犠牲に<br>貴方のエゴを押し付けると？
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B900_010030")


	--★★ペレス★★:いいえ。選択の余地を示すのです<br>ブルーノ卿の子らに
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010031")


	--★★ペレス★★:『継承者とその劔に相応しき孤高な栄光の道』か<br>『バルバロイと溶け合う堕落的な生の道』か
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010032")


	--★★ペレス★★:さすればどうです？いずれ避けられぬ二者択一<br>真なる騎士ならば自ら前者を選ぶでしょう
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010033")


	--★★ペレス★★:このぺレスを愚か者と蔑み<br>己の責務と向き合うことでしょう
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010034")


	--★★ペレス★★:改めて示された選択肢を<br>自らで改めて選び取ることで…
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ペレス★★:後悔などせぬと心に誓える<br>誰にも後悔などさせぬと強く刻める
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010037")


	--★★ブルーノ★★:捨て石となるおつもりか…？
	Talk(Actor002,"CHRNAME_BRUNO","speech","L","MA_01B900_010038")


	--★★ペレス★★:ブルーノ卿の血と剣を分けた子らです<br>銀卓は彼らの足がかりとなりましょう
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ペレス★★:一千年のあいだ<br>悔やませぬために
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010041")

	change_face(Actor002,"Smile")

	--★★ブルーノ★★:…すべては我が子らの選択次第か
	Talk(Actor002,"CHRNAME_BRUNO","speech","L","MA_01B900_010043")

	change_face(Actor003,"Sad")

	--★★ペレス★★:エゴを押し通すようで心苦しいですがね<br>…ニニアン様
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010044")

	change_face(Actor001,"Sad")

	--★★ニニアン★★:エゴと言うならば…<br>この妖精ニニアンも同様ですね
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B900_010045")

	change_face(Actor001,"Normal")

	--★★ニニアン★★:わかりましたぺレス。継承者の選択に託します<br>その代わり──…
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B900_010046")

	change_face(Actor001,"Sad")

	--★★ニニアン★★:私が穢した血族がバルバロイとなり<br>世界を脅かすことがあれば…
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B900_010047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ペレス★★:その血を絶やしましょう<br>我ら銀卓がバルバロイと成り果てる前に
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01B900_010048")

	change_face(Actor001,"Normal")

	--★★ニニアン★★:罪を贖うべく私も命を捧げます<br>ですが呪いは拭いきれません…
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B900_010049")

	change_face(Actor001,"Sad")

	--★★ニニアン★★:頼めた義理ではない<br>それでもあの子だけは守りたい
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B900_010051")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ニニアン★★:あの子に罪などありはしない
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B900_010053")

	change_face(Actor001,"Normal")

	--★★ニニアン★★:私が愛したユーサーとの──…
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B900_010055")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	InitializeCharacter_2DOnly_Preload("101067","001","101067001")
	InitializeCharacter_2DOnly_Preload("101021","003","101021003")
	InitializeCharacter_2DOnly_Preload("101056","001","101056001")
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
