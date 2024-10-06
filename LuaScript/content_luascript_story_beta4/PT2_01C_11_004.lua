-- このluaスクリプトは、PT2_01C_11_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ラロゥ！？なんでここにいるんだ！？<br>まさか、忍び込んだんじゃないよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0040002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:掃除してた人に<br>ノワールの親戚だって言ったら入れてくれたよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","PT2_01C_11_0040003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:この学園の警備って意外とユルいよね<br>学園祭のときだってさ…
	Talk(Actor002,"CHRNAME_LAROU","speech","L","PT2_01C_11_0040004")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:学園祭のときになんだ？<br>なにか悪さをはたらいたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0040005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力

	--★★ラロゥ★★:なんにもやってないよ<br>ノワールたちの迷惑になるようなことは
	Talk(Actor002,"CHRNAME_LAROU","speech","L","PT2_01C_11_0040006")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:まったくお前ってやつは…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0040007")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:でもまあ、今は仕方ないというか…<br>いろいろあって、あちこち人手不足だからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0040008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:円卓の騎士がいるから…なんて油断してると<br>万が一の事態が起きたとき対処しきれないよ？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","PT2_01C_11_0040009")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:うっ…！<br>耳が痛いな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0040010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:それよりお前！<br>今度のハロウィンは大人しくしてろよ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0040011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:大丈夫大丈夫<br>騒ぎを起こすつもりはないよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","PT2_01C_11_0040012")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:本当だろうな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0040013")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラロゥ", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:本当だって、起こさないよ<br>町じゅうがパニックになるような大騒ぎはさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","PT2_01C_11_0040014")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
