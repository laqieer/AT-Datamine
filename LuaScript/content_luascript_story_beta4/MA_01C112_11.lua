-- このluaスクリプトは、MA_01C112_11.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera002 = SetTemplate("Actor002",281.5,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
set_common_look_at(Actor001,Actor002)
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115074)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:うーん！<br>風がひんやりして気持ちいいね～
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_110002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:これだけひんやりしてたら<br>頭も冷えそうじゃない？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_110003")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:兄さんのこんがらがった頭も<br>スッキリするかも。ね？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_110004")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:…気を遣われてるなぁ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_110005")

	change_face(Actor001,"Surprise")

	--★★ディナタン★★:あ、気づいちゃった
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_110006")


	--★★ノワール★★:はは…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_110007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(0.7)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★ノワール★★:…不安なんだ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_110009")


	--★★ノワール★★:ただ継承者ってだけで<br>俺がみんなを率いていいのかって
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_110010")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:兄さん…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_110011")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ノワール★★:継承者がなんなのか<br>ろくにわかってもいない
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_110012")


	--★★ノワール★★:本当のことなんて<br>なにひとつ知らないくせに
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_110013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力

	--★★ノワール★★:アーサーやランスロットのように<br>みんなを率いることが、俺にできるんだろうか
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_110014")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Anger")

	--★★ディナタン★★:…もう！<br>またひとりでこんがらがってる！
	Talk(Actor001,"CHRNAME_DINATAN","speech","N","MA_01C112_110015")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:誰かにならなくていいの<br>兄さんは兄さんのままで
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_110016")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:王様でも最強騎士でもない<br>兄さんは兄さんだからいいの
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_110017")

	change_face(Actor002,"Surprise")

	--★★ノワール★★:ディナタン…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_110018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Normal")

	--★★ディナタン★★:本当のことなんてきっと<br>誰もわからない
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_110019")


	--★★ディナタン★★:忘れてしまってもいい
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_110020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:でも、みんなを守りたくて<br>そのために武器を取った
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_110021")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:兄さんのその気持ちだけは<br>『本当』だって私は知ってる
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_110022")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:だから…<br>がんばろうね、兄さん
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_110023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:…がんばるよ、私
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_110024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:ありがとう、ディナタン
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_110025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:…うん?
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_110026")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115074)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
