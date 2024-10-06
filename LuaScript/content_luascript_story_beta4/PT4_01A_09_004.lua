-- このluaスクリプトは、PT4_01A_09_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
lookat_weight(Actor003,0.5,0.1,0.8,0.2)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力

	--★★フレン★★:ノワールくん<br>ちょうどいいところに
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT4_01A_09_0040002")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ん？<br>俺になにか用か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_09_0040003")

-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力

	--★★ラシア★★:この前のギネヴィア王妃の演説<br>あなたはどう思ってるのかを聞かせてください
	Talk(Actor003,"CHRNAME_RASIA","speech","L","PT4_01A_09_0040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうって…<br>もちろん俺は彼女の考えに賛同するつもりだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_09_0040005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:そうだよね、ＧＳしたくらいだもん<br>ノワールくんは王妃殿下の味方だよね
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT4_01A_09_0040006")


	--★★フレン★★:ローマは敵だって思ってるんでしょ？
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT4_01A_09_0040007")

	change_face(Actor002,"Sad")

	--★★フレン★★:私たちとは<br>もう仲良くできないってことでしょ？
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT4_01A_09_0040008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ちょ、ちょっと待ってくれフレン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_09_0040009")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ルーシャスが何故俺たちを裏切り<br>ロンディニウムであんなことを起こしたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_09_0040010")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:その真相はわからない<br>でも、たとえそれがわかったとしても
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_09_0040011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺とルーシャスが相容れない関係であることは<br>覆らないと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_09_0040012")

	change_face(Actor001,"Sad")

	--★★ノワール★★:だけど、だったら俺とフレンやラシアが<br>敵同士かというと話は別で…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_09_0040013")

-- ▼直接出力
PlayPartVoice("フレン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:ノワールくん<br>今の君みたいな態度をなんて言うか知ってる？
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT4_01A_09_0040014")


	--★★フレン★★:八方美人
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT4_01A_09_0040015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",0.8)
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラシア★★:やめましょう、フレン<br>ノワールはなにも悪くないもの
	Talk(Actor003,"CHRNAME_RASIA","speech","L","PT4_01A_09_0040016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★フレン★★:…そうだね、ごめん
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT4_01A_09_0040017")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.6)
wait_time(0.3)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.7)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:ノワールくん、席を外してもらっていいかな？<br>ラシアとふたりでもう少し話したいの
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT4_01A_09_0040018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:あ、ああ<br>それじゃ、また…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_09_0040019")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
