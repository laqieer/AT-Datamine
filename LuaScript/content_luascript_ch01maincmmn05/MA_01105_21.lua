-- このluaスクリプトは、MA_01105_21.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_014,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_014)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_020,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_020)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_021,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_021)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_019,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_019)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor007,"to  Std_Worry")
	change_face(Actor007,"Sad")

	--★★ガウェイン★★:割り切れねーよな
	Talk(Actor007,"CHRNAME_GAWAIN","speech","L","MA_01105_210002")


	--★★ケイ★★:カレドニアは完全に<br>ログレスを潰す準備に入っていると見て良い…
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01105_210003")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ランスロット★★:だが剣の祭壇を再び奪われるわけにもいかない<br>反撃に転じるのなら猶予はないな
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01105_210004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:敵布陣はマーリンの情報で把握した
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_210005")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:皆様のおかげです<br>一般兵では、ああは行きません
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01105_210006")

	PlayAction(Actor006,"to  Std_No")
	change_face(Actor006,"Sad")

	--★★ギネマウア★★:ですが…申し訳ございません<br>殿下は自室でお休みをいただいております
	Talk(Actor006,"NPCNAME_0070","speech","L","MA_01105_210007")

	change_face(Actor007,"Normal")

	--★★ガウェイン★★:殿下が自分の目で確かめてえって気持ち<br>俺はわかるぜ、だからついてったんだ
	Talk(Actor007,"CHRNAME_GAWAIN","speech","L","MA_01105_210008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor005,"Normal","MA_01105_210010","MA_01105_210011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★ノワール★★:無理もない
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01105_210013")

	change_face(Actor006,"Sad")

	--★★ギネマウア★★:随分、無理をしておいででした
	Talk(Actor006,"NPCNAME_0070","speech","L","MA_01105_210014")

-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor005, false)
lookat_delay_weight_reset(Actor005 , 0.6)
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor005,95.8,0.5)
wait_time(0.5)
PlayActionDirect(Actor005,"to  Std_Talk")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ノワール★★:俺が彼女に<br>何かしてあげられることはないですか？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01105_210015")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
keep_ik_lookat(Actor006,Actor005,"J_Head")
lookat_delay_weight(Actor006, 0.8,0,0.5,0.35,1)
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★ギネマウア★★:お気持ちだけで、結構です<br>殿下にはそのお心遣いだけで、今は…
	Talk(Actor006,"NPCNAME_0070","speech","L","MA_01105_210016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:大丈夫<br>きっとすぐにいつもの彼女に戻るさ
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01105_210018")

-- ▼直接出力
keep_ik_lookat(Actor006,Actor005,"J_Head")
lookat_delay_weight(Actor006, 0.8,0,0.5,0.35,1)
PlayActionDirect(Actor006,"to  Std_Talk")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ギネマウア★★:残酷なことを仰せになりますね、ノワール様
	Talk(Actor006,"NPCNAME_0070","speech","L","MA_01105_210019")

	change_face(Actor006,"Sad")

	--★★ギネマウア★★:殿下のご心痛<br>お分かりにならないと見える
	Talk(Actor006,"NPCNAME_0070","speech","L","MA_01105_210020")

	PlayAction(Actor007,"to  Std_Worry")
	change_face(Actor007,"Sad")

	--★★ガウェイン★★:…いつまでもヘコんでる<br>殿下を見たくねーけど、まあ確かにな…
	Talk(Actor007,"CHRNAME_GAWAIN","speech","L","MA_01105_210021")

	goto Block1end

::Block1end::
-- ▼直接出力
lookat_delay_weight_reset(Actor006 , 0.6)
PlayActionDirect(Actor006,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ギネマウア★★:あれほど外に出たがっていたあの子が<br>今は籠り切りとは…皮肉ですね
	Talk(Actor006,"NPCNAME_0070","speech","L","MA_01105_210023")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor005,0,0)
-- ▲直接出力

	--★★ランスロット★★:早急に善後策を講じよう
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01105_210024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:詳しくは追って通達させる<br>諸君は…今日のところはゆっくり休んでおけ
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01105_210025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★アーサー★★:…まいったよ<br>交渉はすべて無視されてしまっている
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_210026")

	change_face(Actor004,"Sad")

	--★★マーリン★★:それはカレドニアのことですか？<br>それともギネヴィア様のことでしょうか
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01105_210027")


	--★★アーサー★★:どちらの扉も開かぬままだ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_210029")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
