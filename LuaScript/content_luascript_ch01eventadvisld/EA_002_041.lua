-- このluaスクリプトは、EA_002_041.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",288,CharaPos114011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_005)
	Camera002 = SetTemplate("Actor002",-130,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	Camera003 = SetTemplate("Actor003",-129.9,CharaPos114011_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_008)
	Camera004 = SetTemplate("Actor004",112.3,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	Camera005 = SetTemplate("Actor005",-130,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_CoinTossController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	Camera006 = SetTemplate("Actor006",112.3,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_CoinTossController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
set_pos(Actor004,{-0.5,0,2.52})
set_pos(Actor006,{-0.5,0,2.52})
Hide(Actor005)
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
coin = setup_prop_object(10201016)
-- ▲直接出力
-- ▼直接出力
coin_offset = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
on_parent(coin,Actor005, "Loc_weapon_constrint_R", coin_offset)
-- ▲直接出力
-- ▼直接出力
Ef_0001 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_ELine_Holizonal01_Lop", false, false)
-- ▲直接出力
-- ▼直接出力
Ef_0002 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_ELine_Radial01_Lop", false, false)
-- ▲直接出力
-- ▼直接出力
FX_MotionBlur = load_postprocess("content_adv_postprocess", "Ef_C_PP_MotionBlur", false)
-- ▲直接出力
-- ▼直接出力
off_active(Ef_0001 )
off_active(Ef_0002 )
-- ▲直接出力
-- ▼直接出力
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
off_active(FX_DoF)
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({-0.154, 0.99, -1.206,   355.865, 355.29, 0,   15.75258})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Antagonism")
-- ▲直接出力
-- ▼直接出力
load_image("102050030", "content_still_10205003_image", "102050030_StillImage")
show_image("102050030", 0.0, 0.0, 0 ,false,false)

-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME+STILL_PASSIVE_AFTER)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ", "0002")
-- ▲直接出力

	--★★イゾルデ★★:<ruby=オールイン>全賭け</ruby>でいくわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041002")

-- ▼直接出力
PlayPartVoiceDirect("山賊", "0033")
-- ▲直接出力

	--★★山賊★★:リターンマッチ一投目から？<br>正気かね？
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041003")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ", "0008")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Normal")

	--★★イゾルデ★★:致死薬の倍額だけ──なんてケチは言わない<br>ノワールの財布もヴォールスの財布も賭けるわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","N","EA_002_041004")

	open_cutin(1,2)
	on_cutin(1,Actor001,"Surprise")
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
	on_cutin(2,Actor003,"Surprise")
-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:えええ！？<br>ええええ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","N","EA_002_041006")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ヴォールス", "驚き")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor003,"Surprise")

	--★★ヴォールス★★:ま、待てイゾルデ！！<br>財布には仕入れ用の費用が──
	Talk(Actor003,"CHRNAME_BORS","speech","N","EA_002_041007")

	close_cutin()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ", "0007")
-- ▲直接出力

	--★★イゾルデ★★:だから連れて来たのよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041008")

-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor003,true)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("山賊", "否定")
-- ▲直接出力

	--★★山賊★★:足らんね
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041009")


	--★★山賊★★:聞くが<br>ルペトンビターバルを飲むのはお嬢さんかい？
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041011")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:…私の、大切な人に贈るのよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041012")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("山賊", "0010")
-- ▲直接出力

	--★★山賊★★:だから覚悟が足らんのだね
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041013")


	--★★山賊★★:自らの穏やかな死を得んとする者は<br>すべてを投げ打っても惜しくはないと言うのだが
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★イゾルデ★★:………私が欲しいの？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041015")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("山賊", "肯定2")
-- ▲直接出力

	--★★山賊★★:見たところキャメロットの学生さんだろう？<br>健康そうだ。爪の先から内臓の裏側まで
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ", "0046")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:…いいわ<br>負けたら私のすべてを支払いに充ててちょうだい
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041017")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ノワール★★:イゾルデ…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_041018")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("山賊", "喜び")
-- ▲直接出力

	--★★山賊★★:気に入ったよ！ミニマムギャンブラー！<br>なら一発勝負、変則ルールのコイントスとしよう
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041019")

	change_face(Actor002,"Surprise")

	--★★イゾルデ★★:変則ルール？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("山賊", "0009")
-- ▲直接出力

	--★★山賊★★:まず<br>商品の致死薬をふたつの杯に入れて、互いに飲む
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041021")


	--★★山賊★★:一応致死薬に対する解毒薬というものもあってね<br>ただ解毒薬はいま…一瓶しか持ち合わせがない
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041023")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:………解毒薬を賭けて、勝負する…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_041024")

-- ▼直接出力
PlayPartVoiceDirect("山賊", "0007")
-- ▲直接出力

	--★★山賊★★:勝った者は解毒薬と報酬を得る<br>負けた者は死ぬ…乗るかね？お嬢さん
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041025")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ヴォールス★★:無茶だ、こんな賭け！<br>イゾルデ…ここは冷静に──
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_002_041026")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
wait_time(0.7)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:…<ruby=コール>承知したわ</ruby>
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041027")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
setup_small_camera_start()
 --[[
Hide(Actor002)
Hide(Actor004)
Appear(Actor005)
Appear(Actor006)
 --]]
SkipDefaultMotion(Actor006)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("山賊", "肯定2")
-- ▲直接出力

	--★★山賊★★:さて、ふたつの杯に致死薬は注がれた<br>勝負は前回同様『コイントス』だ
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:イカサマがないか確認したいわ<br>コインを貸して。試しに一度トスさせて欲しいの
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041030")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
wait_time(0.44)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
PlayActionDirect(Actor004,"to  Std_Talk")
PlayPartVoice("山賊", "肯定")
-- ▲直接出力

	--★★山賊★★:どうぞご自由に
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041031")

-- ▼直接出力
wait_time(2.0)
CloseTalkWindow()
 --setup_small_camera_start(Camera005)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor005)
DontChangeRandomCamera(true)
Hide(Actor002)
Appear(Actor005)
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to CoinToss02")
wait_time(2.2)
-- ▲直接出力
-- ▼直接出力
 --wait_time(0.5)
PlayActionDirect(Actor003,"to  Std_Worry")
wait_time(3.7)
-- ▲直接出力

	--★★山賊★★:………ずいぶん高く飛ばすんだねえ
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041033")

-- ▼直接出力
wait_time(0.1)
CloseTalkWindow()
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to CoinToss03")
wait_time(1.3)
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to CoinToss04")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★イゾルデ2★★:コインの表裏で重さに差があれば<br>飛びかたでわかるかしらと思ったけれど──
	Talk(Actor005,"CHRNAME_ISOLDE","speech","L","EA_002_041034")

-- ▼直接出力
 --setup_small_camera_end()
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
set_animationcontroller(Actor005, "Chr_505_01_StdController", "to  Std_Talk")
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("山賊", "笑い")
-- ▲直接出力

	--★★山賊★★:悪あがきは<br>もうイイかね？
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041036")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor005)
set_animationcontroller(Actor004, "Chr_030_01_CoinTossController", "to Std_Loop")
on_parent(coin,Actor004, "Loc_weapon_constrint_R", coin_offset)
PlayActionDirect(Actor004,"to CoinToss01")
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ2★★:………致死薬、いただくわ<br>お前も同時に飲むのよ
	Talk(Actor005,"CHRNAME_ISOLDE","speech","L","EA_002_041038")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CameraEx_01)
slidemove(CameraEx_01,-0.202,0.99,-1.21,6)
 Hide(Actor005)
 Appear(Actor002)
keep_ik_lookat(Actor002,Actor004,"J_Head")
-- ▲直接出力

	--★★山賊★★:（ちょろい）
	Talk(Actor004,"NPCNAME_0303","mind","N","EA_002_041040")

-- ▼直接出力
PlayPartVoice("山賊", "肯定3")
-- ▲直接出力

	--★★山賊★★:飲んだ薬の効き目は徐々に出始める<br>早めに決着をつけよう
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:コインを投げて<br>お前が死ぬ前にさっさとね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041042")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera006)
wait_time(0.2)
PlayActionDirect(Actor004,"to CoinToss02")
wait_time(3.0)
-- ▲直接出力

	--★★山賊★★:（投げたコインに不正はない…だがキャッチ後に<br>こっそり指で面をなぞり絵柄は確かめられる）
	Talk(Actor004,"NPCNAME_0303","mind","N","EA_002_041044")

-- ▼直接出力
wait_time(0.5)
CloseTalkWindow()
PlayActionDirect(Actor004,"to CoinToss03")
wait_time(2.5)
-- ▲直接出力

	--★★山賊★★:（手を開く瞬間に望む面を出すことも容易だ<br>少し集中が必要だがこんなガキ相手なら…）
	Talk(Actor004,"NPCNAME_0303","mind","N","EA_002_041045")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("山賊", "0007")
-- ▲直接出力

	--★★山賊★★:さてコインはオレの手の中、選ばせてやろう<br>出目は表か裏か…ミニマムギャンブラー？
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041047")


	--★★山賊★★:（さらにオレが飲んだ致死薬は偽物だ<br>ガキが飲んだほうだけが本物…）
	Talk(Actor004,"NPCNAME_0303","mind","N","EA_002_041048")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★イゾルデ★★:………じゃあ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041049")


	--★★山賊★★:（オレが負けることは<br>万に一つもない）
	Talk(Actor004,"NPCNAME_0303","mind","N","EA_002_041050")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,120,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
set_enable_auto_lookat(Actor002, false)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力

	--★★イゾルデ★★:ノワール
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041051")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.52)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★山賊★★:………え？
	Talk(Actor004,"NPCNAME_0303","speech","L","EA_002_041053")

-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor003,true)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Antagonism")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:選んでノワール
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041054")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0028")
-- ▲直接出力

	--★★ノワール★★:お、俺が…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_041055")


	--★★イゾルデ★★:表か裏か。早くなさい<br>死んでしまうわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041056")

-- ▼直接出力
PlayPartVoiceDirect("イゾルデ", "0042")
-- ▲直接出力

	--★★イゾルデ★★:おねがい
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041058")

	open_select_window_tag(Actor001,"Normal","EA_002_041060","EA_002_041061")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("山賊", "驚き")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★山賊★★:な、な、バカな…！？<br>他人に選択を委ねるのか、なぜ──
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041063")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("山賊", "驚き")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★山賊★★:な、な、バカな…！？<br>他人に選択を委ねるのか、なぜ──
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041063")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera003)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:あ。それとヴォールス<br>致死薬の杯もちゃんと確認してくれたかしら？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041064")

-- ▼直接出力
PlayPartVoice("山賊", "苦しみ")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★山賊★★:！？！？<br>な、に、を言ってる…！？なにを…！？
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041065")

-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:あ、ああ。コインを試しに高く投げているときに<br>杯もイカサマがないか確かめてみたんだがな…
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_002_041066")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ヴォールス★★:よくわからなかったから<br>ふたつの杯を入れ替えて戻してしまったが………
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_002_041067")

-- ▼直接出力
CameraEX = set_camera({-0.35, 1.57, 1.4,   9.09999, 357.3, 0,   22})
setup_small_camera_start(CameraEX)
on_active(FX_DoF)
shake_camera(CameraEX, 0.3, 0.33)
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("山賊", "怒り")
-- ▲直接出力

	--★★山賊★★:エーッ！？な、なに、なにィィッ！？！？<br>つまり…オレの杯に入っていたのは──…！？
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041069")

-- ▼直接出力
CloseTalkWindow()
off_active(FX_DoF)
setup_small_camera_start(Camera005)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,230,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★イゾルデ★★:…なにかお困り？早く手を開きなさい<br>モゾモゾせず、小細工なしで、コインを見せるの
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041070")

-- ▼直接出力
setup_small_camera_start(CameraEX)
on_parent(Ef_0001, CameraEX, "", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)
on_active(Ef_0001)
on_active(FX_DoF)
se_play("SE_ADV_EA_002_041_Heartbeat_Loop")
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("山賊", "驚き")
-- ▲直接出力

	--★★山賊★★:ど、どこから来る！？その自信は…！？<br>他人に選択を任せ、勝算があると！？！？
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041071")


	--★★山賊★★:（ハ…ハッタリか！？わからん、だが負けたら…<br>解毒薬は一瓶しかない、奴らに飲まれたら…！）
	Talk(Actor004,"NPCNAME_0303","mind","N","EA_002_041072")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Normal")

	--★★イゾルデ★★:私は<ruby=フェイルノート>必中の弓</ruby><br><dot>必ず当てる</dot>
	Talk(Actor002,"CHRNAME_ISOLDE","speech","N","EA_002_041073")

	close_cutin()
-- ▼直接出力
off_active(FX_DoF)
off_active(Ef_0001)
se_play("SE_ADV_Loop_Stop")
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("山賊", "苦しみ")
-- ▲直接出力

	--★★山賊★★:あ、うぅウっ…！だが負けたら終わりだぞ！？<br>考え直せ、そうだ賭けを降りろ、そうすれば──
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041075")

-- ▼直接出力
PlayPartVoice("イゾルデ", "否定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★イゾルデ★★:薬の効き目が見たいから、イヤ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041076")

-- ▼直接出力
setup_small_camera_start(CameraEX)
off_active(Ef_0001)
on_active(FX_DoF)
on_screencolor("#FFFFFF", -180, 0)
se_play("SE_ADV_EA_002_041_Heartbeat_Loop")
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("山賊", "悲しみ")
-- ▲直接出力

	--★★山賊★★:いやしかし…しかしいや、だがしかし…！<br>ハーッ！ハーッ！ちょっとタンマ、タンマで…！
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041078")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:命がけ<br>まさかはじめて？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_041080")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★山賊★★:（わ、わからん、集中できん、面がどっちか…！<br>指！指がうまく動かん！運が悪ければ、死──）
	Talk(Actor004,"NPCNAME_0303","mind","N","EA_002_041081")

-- ▼直接出力
off_screencolor()
off_active(FX_DoF)
se_play("SE_ADV_Loop_Stop")
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "怒り")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Anger")

	--★★イゾルデ★★:さっさと出しなさい<br>表か、裏か、ほら、ほぉら
	Talk(Actor002,"CHRNAME_ISOLDE","speech","N","EA_002_041082")

-- ▼直接出力
 --se_play("SE_ADV_EA_002_041_Heartbeat_Loop")
-- ▲直接出力
	close_cutin()

	--★★山賊★★:ど、どどどど、どどどどどど………！！
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041083")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:ど？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_041084")

-- ▼直接出力
setup_small_camera_start(CameraEX)
on_parent(Ef_0002, CameraEX, "", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)
on_active(Ef_0002)
on_active(FX_DoF)
shake_camera(CameraEX, 0.3, 0.33)
 --se_play("SE_ADV_Loop_Stop")
se_play("SE_ADV_EA_002_041_don")
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("山賊", "気合い")
-- ▲直接出力

	--★★山賊★★:どっちでもいいわあああぁぁぁッッッ！！
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_041085")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10201016)
coin_offset = {0,0,0,0,0,0}
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_ELine_Holizonal01_Lop", false, false)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_ELine_Radial01_Lop", false, false)
load_postprocess_preload("content_adv_postprocess", "Ef_C_PP_MotionBlur", false)
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
preload_sound("BGM_ADV_Antagonism")
load_image_preload("102050030", "content_still_10205003_image", "102050030_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
