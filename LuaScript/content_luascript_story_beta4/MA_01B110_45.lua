-- このluaスクリプトは、MA_01B110_45.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_03","111016_03_h")
Include("content_adv_advsmall_111016_03","Template111016_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111016_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111016_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_015_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111016_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_016_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111016_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_017_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_003)
	Camera005 = SetTemplate("Actor005",180,CharaPos111016_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111016_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_002)
	InitializeTemplateRandomCamera111016_03()
	InitializeTemplate111016_03()
-- ▼直接出力
Ef_Aura_Enemy1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
Ef_Aura_Enemy2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
Ef_Aura_Enemy3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
Ef_Aura_Enemy4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
local EfPos = get_pos(Actor001)
set_pos(Ef_Aura_Enemy1 , EfPos)
on_active(Ef_Aura_Enemy1) 
play_particle(Ef_Aura_Enemy1)
local EfPos = get_pos(Actor002)
set_pos(Ef_Aura_Enemy2 , EfPos)
on_active(Ef_Aura_Enemy2) 
play_particle(Ef_Aura_Enemy2)
local EfPos = get_pos(Actor003)
set_pos(Ef_Aura_Enemy3 , EfPos)
on_active(Ef_Aura_Enemy3) 
play_particle(Ef_Aura_Enemy3)
local EfPos = get_pos(Actor004)
set_pos(Ef_Aura_Enemy4 , EfPos)
on_active(Ef_Aura_Enemy4) 
play_particle(Ef_Aura_Enemy4)
change_face(Actor005,"Anger")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor006,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111016)
	Actor001 = InitializeCharacter_3D("101056","001","101056001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101053","002","101053002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101054","002","101054002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101055","002","101055002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101029","001","101029001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start()
 --PlayPartVoice("モーロノエー", "挨拶")
-- ▲直接出力

	--★★モーロノエー★★:お別れは告げたのかしら、ご老人？
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","L","MA_01B110_450002")

-- ▼直接出力
setup_small_camera_end()
 --PlayPartVoice("ペレス", "笑い")
-- ▲直接出力

	--★★ペレス★★:そなたこそ<br>妹たちを喪った涙はないのか
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B110_450003")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ペレス★★:わざわざ継承者らを<br>ガラハッドのもとへ導くような真似までして
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B110_450005")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "笑い")
-- ▲直接出力

	--★★モーロノエー★★:魔女姉妹──バルバロイはいわば群体<br>個々の意志なぞ希薄、幻のようなものよ
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","L","MA_01B110_450006")


	--★★モーロノエー★★:『魔王』のため『楽園』への道を拓くためなら<br>自ら身を投じることを辞さないの
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","L","MA_01B110_450007")

	change_face(Actor006,"Smile")

	--★★モーロノエー★★:そういう意味ではご老人？
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","L","MA_01B110_450008")

	change_face(Actor006,"Normal")

	--★★モーロノエー★★:人の身でその覚悟、その自己犠牲には<br>見上げたものがあるわ…銀卓騎士団の諸君もね
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","L","MA_01B110_450009")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ペレス", "激怒")
-- ▲直接出力

	--★★ペレス★★:いずれひとつとなる身<br>これは別離ではない
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B110_450011")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor006,1)
-- ▲直接出力

	--★★モーロノエー★★:銀卓騎士が3脚<br>マターヤ、アダン、オーウェン…
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","L","MA_01B110_450012")

	PlayAction(Actor006,"to  Std_Talk")

	--★★モーロノエー★★:その身が深く傷つけば傷つくほど<br>我ら姉妹との結合はより深く、強固となる
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","L","MA_01B110_450013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★モーロノエー★★:卓の傷…その溝に汚れがこびりつき取れぬように<br>抉れば抉るほどもとの形を保てぬように
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","L","MA_01B110_450014")

	change_face(Actor006,"Smile")

	--★★モーロノエー★★:もはや銀卓騎士たちの彼我の境界は失われ<br>物言わぬバルバロイの傀儡と化していく
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","L","MA_01B110_450016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★モーロノエー★★:もちろん、鍛え抜かれた力はそのままにね
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","L","MA_01B110_450018")

-- ▼直接出力
 --PlayPartVoice("モーロノエー", "喜び")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★モーロノエー★★:ガラハッドたちは間接的にとはいえ<br>仲間の自我を殺した…もう取り返しはつかなァい
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","L","MA_01B110_450019")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力

	--★★ペレス★★:………円卓に聖杯をあげては、ならぬ
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B110_450020")

	change_face(Actor001,"Sad")

	--★★ペレス★★:銀卓騎士団が果たすべき<br>…最期の、務め、だ
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B110_450021")

	change_face(Actor001,"Normal")

	--★★ペレス★★:父なる彼に…誓いを立てよ<br>穢れし血を絶やして救え………
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B110_450023")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera001)
wait_time(0.5)
PlayActionDirect(Actor002,"to Bow")
wait_time(0.2)
PlayActionDirect(Actor004,"to Bow")
wait_time(0.1)
PlayActionDirect(Actor003,"to Bow")
wait_time(3)
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★アステラ★★:…淀みの底へとすがってみせるわ<br>物言わぬ捨て石になろうと
	Talk(Actor005,"CHRNAME_ASTERA","speech","L","MA_01B110_450025")


	--★★ペレス★★:聖杯を穢し、継承者とその劒を<br>家庭へ迎え入れ、そして──
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B110_450026")

	change_face(Actor001,"Anger")

	--★★ペレス★★:──アーサーを、殺せ
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B110_450028")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
set_common_look_at(Actor006,Actor001)
 --PlayPartVoice("モーロノエー", "挨拶")
-- ▲直接出力

	--★★モーロノエー★★:勘当した子たちの処遇は？
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","L","MA_01B110_450029")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ペレス", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ペレス★★:フィエナもガラハッドも<br>もはや我らの道の上にはない
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B110_450030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor005)
lookat_delay_weight_reset(Actor006,1)
-- ▲直接出力

	--★★アステラ★★:帰って来ても居場所はない<br>合わせる顔もひとつとしてない
	Talk(Actor005,"CHRNAME_ASTERA","speech","L","MA_01B110_450031")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★アステラ★★:置き去るのみよ
	Talk(Actor005,"CHRNAME_ASTERA","speech","L","MA_01B110_450032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ペレス★★:いくら、駄々をこねようとな
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B110_450033")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
	InitializeLoad_Preload()
	load_area_scene_preload(111016)
	InitializeCharacter_3D_Preload("101056","001","101056001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101053","002","101053002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101054","002","101054002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101055","002","101055002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101029","001","101029001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111016_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
