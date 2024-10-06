-- このluaスクリプトは、MA_01A111_27.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookWeight = {0.6, 0, 0.7, 0.35}
lookat_delay_weight(Actor002, lookWeight,2)
keep_ik_lookat(Actor002, Actor003, "J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガウェイン★★:暗いカオすんなよ、ラグネル
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_270002")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:なーに言ってんの？<br>いつも明るい太陽みたいなラグネルだよ？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_270003")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力

	--★★ガウェイン★★:最近妙にはしゃいでたろ<br>お前が特別明るいときはなんかあんだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_270004")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:わかるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_270005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:フツーだろ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_270006")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:…あたしたち、ローマの港町で育ってさ<br>言ってなかったっけ
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_270007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:教えてくれるなら聞きたいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_270008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:うん。そこで師匠──ヴェルナルス将軍に会った<br>あの時は将軍じゃなかったかな、わかんないけど
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_270009")


	--★★ラグネル★★:あたしたちは10歳ぐらいのときだっけ<br>ローマ大帝国の秩序を維持すべく港町に現れて…
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_270010")


	--★★ラグネル★★:ノワールも体験したとおり、すっごく強かった<br>娯楽も少なかったあたしたちにとっては──
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_270011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラグネル★★:まさしく英雄、って感じだった
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_270012")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:弱きを助けて悪しきを挫く！そんな姿に憧れて<br>子供のあたしたちは「ししょーししょー！」って
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_270014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:よくも知らねーガキがふたりもチョロチョロとさ<br>だけど、あの人すげえ優しいかったんだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_270015")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "照れ")
-- ▲直接出力

	--★★ラグネル★★:「あなたみたいになりたい」って押しかけて<br>そしたら武術の指南をしてくれたの、こっそりね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_270016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:任務の合間縫ってさ…結構みっちり<br>あの人もダルかっただろうに
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_270017")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:いつだかあたし聞いたんだ<br>「どうしてそんな親切にしてくれるの？」
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_270018")


	--★★ラグネル★★:あの人言ったの
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_270019")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:「断る口実が思いつかん」
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_270020")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:あ。押せばイケる人だって思ったよね<br>まああの人なりの親切心だったんだろうけど
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_270022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラグネル★★:………だから、なんかね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_270023")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力

	--★★ラグネル★★:どっちが<br>良いのかな
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_270025")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
lookWeight = {0.6, 0, 0.7, 0.35}
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
