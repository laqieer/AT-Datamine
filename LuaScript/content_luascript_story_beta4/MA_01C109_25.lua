-- このluaスクリプトは、MA_01C109_25.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_014,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_014)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera011 = SetTemplate("Actor011",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor006)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor008)
DontCameraOffset(Actor009)
DontCameraOffset(Actor010)
DontCameraOffset(Actor011)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor005, Actor003, "J_Head")
lookat_delay_weight(Actor005,1.0,0.02,0.5,0.2,1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor011")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("モルドレッド","挨拶")
-- ▲直接出力

	--★★モルドレッド★★:王座が空席じゃねえの
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","MA_01C109_250002")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor007)
lookat_weight_default(Actor005)
 --PlayPartVoice("マーリン","肯定2")
-- ▲直接出力

	--★★マーリン★★:アーサー王は先の戦いにおける戦傷者を悼むべく<br>席を外させていただいております
	Talk(Actor007,"CHRNAME_MERLIN","speech","L","MA_01C109_250003")

-- ▼直接出力
 --PlayPartVoice("モルドレッド","肯定2")
-- ▲直接出力

	--★★モルドレッド★★:………慈悲深ぇことだな、そりゃ
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","MA_01C109_250005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ","笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ケイ★★:まずはコルベニック城での戦いに<br>参加した者たちに労いの言葉を申したい
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C109_250006")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ケイ★★:犠牲は少なくはなかったが<br>カレドニア王ライエンスを討ち
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C109_250007")


	--★★ケイ★★:聖杯がバルバロイの手に渡ることは<br>阻止できた
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C109_250008")

-- ▼直接出力
 --PlayPartVoice("モルドレッド","挨拶")
-- ▲直接出力

	--★★モルドレッド★★:そうはいうがよ<br>肝心の聖杯の在処はわからずじまい
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","MA_01C109_250009")


	--★★モルドレッド★★:魔女どももライエンスを見棄てて<br>ルーシャスのヤロウについたんだろ？
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","MA_01C109_250010")


	--★★モルドレッド★★:これまでと<br>状況はほとんど同じじゃねえか
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","MA_01C109_250011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット","悩む")
-- ▲直接出力

	--★★ランスロット★★:我らが聖杯城を守ったことで<br>ペレス王からの信頼を得られたし
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01C109_250012")


	--★★ランスロット★★:ルーシャスと魔女たちとは<br>まだハラの探り合いの最中だろう
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01C109_250013")


	--★★ケイ★★:すぐにローマと魔女の連合軍が<br>押し寄せてくることもないはずだ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C109_250014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガレス","落胆")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ガレス★★:束の間の平和ってこと～？
	Talk(Actor006,"CHRNAME_GARETH","speech","L","MA_01C109_250015")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ","肯定")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ケイ★★:うむ。そしてなによりの朗報は<br>継承者がＧＳを果たしたことだろう
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C109_250016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C109_250017","MA_01C109_250018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:紹介するよ<br>俺のキラーズ…アロンダイトだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_250020")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン","挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:よ、よろしくお願いします！<br>ディナタン…いえ、アロンダイトです！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_250021")

-- ▼直接出力
 --PlayPartVoice("モルドレッド","納得")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★モルドレッド★★:まさか妹サンを選ぶたぁねえ<br>オレぁてっきり…
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","MA_01C109_250022")

-- ▼直接出力
setup_small_camera_start(Camera006)
lookat_delay_weight(Actor001, 1.0, 0.5, 0.5, 0.2,0.5)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_delay_weight(Actor002, 1.0, 0.5, 0.5, 0.2,0.5)
keep_ik_lookat(Actor002,Actor001,"J_Head")
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガレス","驚き")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★ガレス★★:モルドレッド、そこまで～！
	Talk(Actor006,"CHRNAME_GARETH","speech","L","MA_01C109_250023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
lookat_delay_weight(Actor001, 1.1, 0.02, 0.4, 0,1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタン、あらためてよろしくな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_250025")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:マスターとキラーズという関係になっても<br>俺たちは変わらず兄妹なんだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_250026")

-- ▼直接出力
lookat_delay_weight(Actor002, 1.0, 0.5, 0.5, 0.2,0.5)
keep_ik_lookat(Actor002,Actor001,"J_Head")
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:うん、こちらこそよろしくね<br>兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_250027")

	change_face(Actor005,"Sad")

	--★★モルドレッド★★:ケッ<br>麗しい兄妹愛だこと
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","MA_01C109_250028")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ","笑い")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ケイ★★:継承者がキラーズを得たことにより<br>ついにバルバロイ根絶の目途が立った
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C109_250030")


	--★★ケイ★★:バルバロイがローマと手を組んだとて<br>キラーズを有する我らの優位は変わらん
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C109_250031")

-- ▼直接出力
lookat_delay_weight(Actor001, 1.0, 0.5, 0.5, 0.2,0.5)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_delay_weight(Actor002, 1.0, 0.5, 0.5, 0.2,0.5)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ケイ★★:こちらから<br>攻勢に出られる日も近いだろう
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C109_250032")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera006)
PlayActionDirect(Actor007,"to  Std_Talk")
wait_time(0.8)
play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
wait_time(0.5)
play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
wait_time(1.0)
setup_small_camera_start(RndCamera005)
play_head_motion(Actor006, "No", 0.3, 1.0, false)
wait_time(0.8)
play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
wait_time(1.5)
setup_small_camera_start(RndCamera009)
change_face(Actor001, "Normal")
wait_time(2.0)
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
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor011")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
