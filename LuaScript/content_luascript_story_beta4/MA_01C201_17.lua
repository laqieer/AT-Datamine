-- このluaスクリプトは、MA_01C201_17.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
force_eyesync(Actor004,"Close")
reserve_eyesync(Actor004,"Close")
--arufa = 0.055
--setup_small_camera_resetting(Actor004,{CharaPos110141_02_001[1],CharaPos110141_02_001[2]+arufa,CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
set_rot(Actor004,{2,CharaPos110141_02_001[4],0})
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115150)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Sad")

	--★★ディナタン★★:ギネヴィアさん、大丈夫なんですか？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_170002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:ええ。ひととおり診たけど身体に異常はないわ<br>体力が回復すれば、じきに目覚めるはずよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01C201_170003")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:よかった…！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_170004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力

	--★★イゾルデ★★:ねぇ、ディナタン<br>悪いけど、少し代わってくれる？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01C201_170005")


	--★★イゾルデ★★:私、ほかの患者の様子も<br>診ないといけないから
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01C201_170006")

-- ▼直接出力
keep_ik_lookat(Actor001, Actor002, "J_Head")
lookWeight = {0.9, 0, 0.7, 0.35}
lookat_delay_weight(Actor001, lookWeight,0.8)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:もちろん！<br>任せてください
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_170007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:頼んだわね。それじゃ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01C201_170008")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
lookat_delay_weight_reset(Actor001 , 1)
Hide(Actor002)
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:ほんとによかった…<br>ギネヴィアさんが戻ってきてくれて
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_170010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ディナタン★★:これできっと<br>兄さんも少しは安心できるよね
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_170011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力

	--★★マルディサント★★:だといいけどな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C201_170012")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:ギネマウアさんも元気だといいんだけど…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_170013")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力

	--★★マルディサント★★:それよりディーナ、看病するのはいいけど<br>あんまり根詰めすぎんなよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C201_170014")

-- ▼直接出力
wait_time(0.3)
setup_small_camera_start()
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,240,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:もう、心配しすぎ！<br>最近は元気だよ！?
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_170015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115150)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
