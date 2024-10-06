-- このluaスクリプトは、MA_01108_24.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_020,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_020)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_021,"content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_021)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_017)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera011 = SetTemplate("Actor011",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera012 = SetTemplate("Actor012",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
load_image("102010100_StillImage", "content_still_10201010_image", "102010100_StillImage")
set_enable_auto_lookat_all(false)
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor008)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor009)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor010)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor011)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor012)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101029","001","101029001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor011")
	Actor012 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor012")
	template1()
	load_head_animation(Actor010,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor012,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ケイ★★:各人<br>首尾を報告していただきたい
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01108_240002")


	--★★ランスロット★★:ガラハッド卿の護衛任務は<br>無事遂行した
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_240003")

	play_head_motion(Actor010, "Nod", 0.3, 1.0, false)

	--★★トリスタン★★:コーンウォール王との謁見も<br>ついでに済ませておいたよ
	Talk(Actor010,"CHRNAME_TRISTAN","speech","L","MA_01108_240004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")

	--★★ガラハッド★★:近々ぺレス王に薬草を届けるべく<br>コルベニック城に戻る。世話になった
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_240005")

	play_head_motion(Actor008, "No", 0.3, 1.0, false)
	change_face(Actor008,"Sad")

	--★★ガレス★★:ブライアンさんは<br>残念だけど見つからなかったよ
	Talk(Actor008,"CHRNAME_GARETH","speech","L","MA_01108_240006")

	change_face(Actor008,"Normal")

	--★★ガレス★★:だけど足取りはつかめた<br>コルベニック城に向かったって
	Talk(Actor008,"CHRNAME_GARETH","speech","L","MA_01108_240007")

	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
	change_face(Actor009,"Smile")

	--★★ガウェイン★★:カレドニア領にローマの補給線を築く<br>任務も終わらせてきたぜ
	Talk(Actor009,"CHRNAME_GAWAIN","speech","L","MA_01108_240008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Worry")
	change_face(Actor007,"Sad")

	--★★ルーシャス★★:ただ、付近には大した戦力が<br>配置されてなかったのが気になるな
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01108_240009")

	change_face(Actor005,"Sad")

	--★★ガラハッド★★:コルベニック城周辺で<br>カレドニア兵の姿も確認されているし…
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_240010")


	--★★ルーシャス★★:そちらに主力を移しているのかもしれぬ<br>…となれば、少々厄介なことだ
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01108_240011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★アーサー★★:なら行くまでだな
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_240012")


	--★★アーサー★★:カレドニアやブライアンの動向を伺いつつ<br>銀卓騎士を送り届けよう
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_240013")

-- ▼直接出力
show_image("102010100_StillImage", 0.0, 0.0, 0.3,false,false)
-- ▲直接出力

	--★★アーサー★★:コルベニック城は<br>またの名を『聖杯城』という
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_240014")


	--★★アーサー★★:城主ぺレス王に謁見が叶えば<br>聖杯探索について協力を得られるかもしれん
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_240015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
hide_image(0.3)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ケイ★★:混乱のさなか、継承者も出現した<br>聖杯の出現も近いと考えれば…急がねばならんか
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01108_240016")


	--★★モルドレッド★★:アーサー王が出張んのかよ？
	Talk(Actor011,"CHRNAME_MORDRED","speech","L","MA_01108_240017")


	--★★アーサー★★:ぺレス王との会談だ<br>俺が行かないわけにはいかないだろう
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_240018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor012, "Nod", 0.3, 1.0, false)

	--★★ヴォールス★★:カレドニア軍に動きがあるかもしれん<br>我らは待機をしていよう。臨戦態勢でな
	Talk(Actor012,"CHRNAME_BORS","speech","L","MA_01108_240019")

	change_face(Actor006,"Sad")

	--★★アステラ★★:コルベニック城へは<br>カーライル城近くの港町から船に乗り海を渡る…
	Talk(Actor006,"CHRNAME_ASTERA","speech","L","MA_01108_240020")


	--★★アステラ★★:そのあとハドリアヌス・ウォールを抜け、到着よ<br>恐らくカレドニア本隊との戦闘は避けられない…
	Talk(Actor006,"CHRNAME_ASTERA","speech","L","MA_01108_240021")

	change_face(Actor004,"Normal")

	--★★アーサー★★:出発はX日後としよう<br>準備は抜かりなくな
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_240022")

	change_face(Actor004,"Normal")

	--★★アーサー★★:スタンド・バイ・ユアラウンド
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_240023")

	open_cutin(1,1)
	on_cutin(1,Actor007,"Normal")

	--★★ルーシャス★★:フォー・ラウンド
	Talk(Actor007,"CHRNAME_LUCIUS","speech","N","MA_01108_240025")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ルーシャス★★:──余もいこう
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01108_240027")

	change_face(Actor003,"Surprise")

	--★★ケイ★★:皇太子殿下自らですかな………？<br>学園でお待ちいただければ──
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01108_240028")


	--★★ルーシャス★★:王や主戦力をコルベニックに傾けているなかで<br>難物である余の面倒を誰がみる？
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01108_240029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★アーサー★★:…ありがたい申し出だ<br>断る理由は見当たらないな
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_240030")

	PlayAction(Actor007,"to  Std_Talk")

	--★★ルーシャス★★:クッククク…断ればもっと面倒になる<br>おとなしく従うことだ
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01108_240031")


	--★★ルーシャス★★:とはいえ小さな島のなかでの問題<br>なあに、余が直接手を出すことはしないさ
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01108_240032")


	--★★ルーシャス★★:どうせすでに父の威を借るアーサー王だ<br>大帝国の威光もついでに貸してやろう
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01108_240033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Normal")

	--★★ガラハッド★★:…コルベニック城への道案内はガラハッドが<br>良いな？ノワール卿、ランスロット卿
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_240035")


	--★★ノワール★★:………ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_240036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:俺たちはふるさとへ帰る理由がある<br>すべてがあの地につながるのなら
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_240038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:ランスロット…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_240039")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:一緒に帰ろう。ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_240040")


	--★★ノワール★★:…フォー・ラウンド
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_240042")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102010100_StillImage", "content_still_10201010_image", "102010100_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101029","001","101029001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor011")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor012")
	load_head_animation_preload(Actor010,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor012,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
