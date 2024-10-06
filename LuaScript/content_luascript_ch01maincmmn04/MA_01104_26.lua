-- このluaスクリプトは、MA_01104_26.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")

function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101120021)
	Actor001 = InitializeCharacter_2DOnly("101009","005","101009005")
	Actor002 = InitializeCharacter_2DOnly("101010","003","101010003")
	Actor003 = InitializeCharacter_2DOnly("101012","004","101012004")
	Actor004 = InitializeCharacter_2DOnly("101060","001","101060001")
	template1()
end

function Play()
	StartPlay()

	change_face(Actor001,"Sad")

	--★★ノワール★★:（現実味がないんだよ<br>妖精を殺したなんて）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01104_260002")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:円卓の騎士ブルーノは<br>『妖精殺し』の咎人として－－
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_260003")

	change_face(Actor004,"Sad")

	--★★セレスティ★★:…そう
	Talk(Actor004,"NPCNAME_0163","speech","L","MA_01104_260004")

-- ▼直接出力
 -- setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:@－－ログレスに追われることとなります
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_260005")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:『妖精殺し』は世を揺るがす大罪<br>ご家族にどんな危険が及ぶかわからない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_260006")


	--★★ランスロット★★:…今夜ここを離れてください<br>ブリテン島へは船を用意させています
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_260007")


	--★★セレスティ★★:………
	Talk(Actor004,"NPCNAME_0163","speech","L","MA_01104_260008")

-- ▼直接出力
 -- setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:妖精仕えの巫女である貴方にとっては<br>御心痛のことと思いますが、どうか－－…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_260009")


	--★★セレスティ★★:…いいえ<br>いつかは来る日だから
	Talk(Actor004,"NPCNAME_0163","speech","L","MA_01104_260010")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:…？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_260011")

-- ▼直接出力
 -- setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:ランス兄ちゃん…？<br>とうさんが、どうして妖精さんを－－…？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_260012")


	--★★ノワール★★:うそだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_260013")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:ノワール、ディナタン…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_260014")

	change_face(Actor001,"Anger")

	--★★ノワール★★:うそだ！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_260015")

-- ▼直接出力
 -- setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:円卓の騎士は聖杯を見つけて<br>世界を平和にするんだろ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_260016")


	--★★ノワール★★:聖杯へ導く妖精さんを守るのが<br>父さんの仕事なんだろ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_260017")


	--★★ノワール★★:父さんが『妖精殺し』なんて<br>そんなの誰が見たんだよ－－…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_260018")

-- ▼直接出力
 -- setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺が、目の前でだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_260019")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…なにを、いってんだ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_260020")


	--★★ランスロット★★:ブルーノ──<br>俺たちの剣の師、お前たちの父親は…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_260021")

	change_face(Actor002,"Anger")

	--★★ランスロット★★:妖精を殺し、その姿を消した
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_260022")

-- ▼直接出力
 -- setup_small_camera_end()
-- ▲直接出力

	--★★セレスティ★★:………
	Talk(Actor004,"NPCNAME_0163","speech","L","MA_01104_260023")

	change_face(Actor004,"Normal")

	--★★セレスティ★★:さあノワール、ディナタン？<br>お引越し、しよっか
	Talk(Actor004,"NPCNAME_0163","speech","L","MA_01104_260024")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ま、待っていようよ…<br>父さんが帰ってくるまで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_260025")

-- ▼直接出力
 -- setup_small_camera_start()
-- ▲直接出力

	--★★セレスティ★★:ランスロット、お願いが
	Talk(Actor004,"NPCNAME_0163","speech","L","MA_01104_260026")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:はい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_260027")


	--★★セレスティ★★:あの人を追って
	Talk(Actor004,"NPCNAME_0163","speech","L","MA_01104_260028")


	--★★ランスロット★★:…そのつもりです<br>真実を知りたい、俺も
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_260030")

-- ▼直接出力
 -- setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:ランス兄ちゃんも、行っちゃうの…？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_260031")


	--★★ノワール★★:また…あえる、よな………？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_260032")


	--★★ランスロット★★:お前の頑張り次第だな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_260033")

-- ▼直接出力
 -- setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだよそれ意味わかんね！<br>とりあえずおまえががんばれよ！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_260034")


	--★★ランスロット★★:言われなくてもそうするさ<br>ふたりで頑張れば必ず会える、そうだろ？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_260035")


	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_260036")


	--★★ランスロット★★:円卓で待ってる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_260037")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101120021)
	InitializeCharacter_2DOnly_Preload("101009","005","101009005")
	InitializeCharacter_2DOnly_Preload("101010","003","101010003")
	InitializeCharacter_2DOnly_Preload("101012","004","101012004")
	InitializeCharacter_2DOnly_Preload("101060","001","101060001")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
end
