-- このluaスクリプトは、CO_101064_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114042_01","114042_01_h")
Include("content_adv_advsmall_114042_01","Template114042_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114042_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114042_01,CameraPos114042_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114042_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName114042_01,CameraPos114042_01_002)
	InitializeTemplateRandomCamera114042_01()
	InitializeTemplate114042_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114042)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()


	--★★リアム★★:剣の祭壇…いつか訪れてみたいと思っていた場所です
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010008")


	--★★リアム★★:なるほど…神聖な空気に満ちていますね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★リアム★★:ログレスの大聖堂とは少し異なりますがこれもまた気が引き締められます
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010010")


	--★★ノワール★★:リアムさんはここに来たのは初めてなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_00010011")


	--★★リアム★★:ええ。私はノワールさんたちのような戦う力は持ち合わせていませんし…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010012")


	--★★リアム★★:入学試験を受けるには年を取りすぎていますから
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010013")


	--★★ノワール★★:…訪れてみたかったって言ってたけどリアムさんにとってなにか特別な場所なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_00010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★リアム★★:特別…そうですね特別と言えるのでしょう
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010015")


	--★★リアム★★:私を今の道へ導いてくださった人生の先生からこの場所のことを何度か聞かされていました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★リアム★★:いつかふたりで訪れようそんな話もしていたのですが…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010017")


	--★★リアム★★:結局その夢は叶わずに終わってしまいました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010018")


	--★★ノワール★★:そうだったのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_00010019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101064_00010020","CO_101064_00010021","CO_101064_00010022")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:リアムさんの先生って人残念だったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_00010024")

	change_face(Actor002,"Normal")

	--★★リアム★★:人々を守る神聖なる剣それを一目見てみたいと先生は仰っていました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010025")

	change_face(Actor002,"Normal")

	--★★リアム★★:私はこの剣について詳しくは存じ上げておりませんが
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010026")

	change_face(Actor002,"Normal")

	--★★リアム★★:持ち主が召されてもその思いがこの地に残り人々を守るのなら
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010027")

	change_face(Actor002,"Normal")

	--★★リアム★★:先生の思いもまた誰かを守ってくれているのでしょうか
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…ああ、きっと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_00010029")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ここはログレスからそんなに離れてないしまたいつでも来ればいいじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_00010032")

	change_face(Actor002,"Normal")

	--★★リアム★★:リアムさんが先生のぶんも兼ねてさ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010033")

	change_face(Actor002,"Normal")

	--★★リアム★★:ここまでの道のりが危険だっていうならいつでも俺が付き合うし
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010034")

	change_face(Actor002,"Normal")

	--★★リアム★★:…ありがとうございます、ノワールさん
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010035")

	change_face(Actor001,"Normal")

	--★★ノワール★★:先生と一緒にここに来ることはできませんでしたが
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_00010036")

	change_face(Actor002,"Normal")

	--★★リアム★★:代わりにあなたと来ることができた
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010037")

	change_face(Actor002,"Normal")

	--★★リアム★★:これは先生のお導きなのかもしれませんね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010038")

	change_face(Actor002,"Normal")

	--★★リアム★★:いや…あなたと出会えたことそれがそもそもの導きなのでしょうか
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010039")

	change_face(Actor001,"Normal")

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_00010040")

	change_face(Actor002,"Normal")

	--★★リアム★★:いえ、なんでもありませんよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010041")

	change_face(Actor002,"Normal")

	--★★リアム★★:さあ、ともに祈りを捧げて今日のところは帰りましょう
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010042")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:今日のところは俺が先生の代わりに祈らせてもらっていいかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_00010045")

	change_face(Actor001,"Normal")

	--★★ノワール★★:もちろん俺なんかじゃ代わりになれないことは理解してるけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_00010046")

	change_face(Actor001,"Normal")

	--★★ノワール★★:リアムさんの先生のぶんまで精一杯、心を込めて祈るつもりだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_00010047")

	change_face(Actor002,"Normal")

	--★★リアム★★:ノワールさん…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010048")

	change_face(Actor002,"Normal")

	--★★リアム★★:祈ることに差などありません主は等しく皆の声を聴いてくれます
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010049")

	change_face(Actor002,"Normal")

	--★★リアム★★:貴方のその真っすぐな思いはきっと主のもとに届くでしょう
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010050")

	change_face(Actor001,"Normal")

	--★★ノワール★★:わかったそれじゃ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_00010051")

	change_face(Actor002,"Normal")

	--★★リアム★★:先生、見てくれていますか？今、私は………
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010052")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"リアム")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114042)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName114042_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
