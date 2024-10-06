-- このluaスクリプトは、MA_01A110_12.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:してしまったってなによ<br>馬鹿にしてる
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_120002")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力

	--★★ラグネル★★:けど、それもわかってるんでしょうね。あの子<br>だからうまく身動きが取れないみたいで
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","MA_01A110_120003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:GSを憎らしく思うことなんて<br>吐いて捨てるほどあるわ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_120004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラグネル★★:あたしもです
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","MA_01A110_120005")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:でも、わたしはお姉ちゃんに手を引かれた<br>…ノワールはわたしの手を取ってくれた
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_120006")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:ラグネル、あなただって<br>ガウェインと手を携えて戦っている
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_120007")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:止まってちゃダメじゃん<br>忘れるワケにいかないじゃん、その時の気持ち
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_120008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:大切な人たちが消え去ってしまうのを<br>引き留める唯一の手段なんだよ？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_120009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:おかげでわたし<br>パパを覚えていられる
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_120010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:いつ喰われて消えちゃうかわかんない<br>その中で誰かと繋がる唯一の武器なんだもん
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_120011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ラグネル★★:当人に伝えたらどうですかー？
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","MA_01A110_120013")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ギネヴィア★★:きっと伝えるわ、彼が
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_120015")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:痛くても痛くても<br>我慢してるのは彼だから
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_120016")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
