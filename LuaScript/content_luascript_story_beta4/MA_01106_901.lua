-- このluaスクリプトは、MA_01106_901.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111031_01","111031_01_h")
Include("content_adv_advsmall_111031_01","Template111031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111031_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_001)
	Camera002 = SetTemplate("Actor002",5,CharaPos111031_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111031_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111031_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_007)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_004)
	Camera008 = SetTemplate("Actor008",nil,CharaPos111031_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_005)
	Camera009 = SetTemplate("Actor009",nil,CharaPos111031_01_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_009)
	InitializeTemplateRandomCamera111031_01()
	InitializeTemplate111031_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111031)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor009")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Smile")

	--★★ガウェイン★★:さっそくリンゴリンゴー！<br>…と言いたいところだけどよ
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01106_9010002")

	change_face(Actor006,"Sad")

	--★★ガウェイン★★:転移を使わずに来たから<br>結構な時間になっちまったよな
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01106_9010003")


	--★★モルガン★★:今日はここに泊まって<br>リンゴ狩りは明日にしたらどうかしら？
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01106_9010004")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Joy")
	change_face(Actor005,"Smile")

	--★★マルディサント★★:久々に<br>モルガン邸のふかふかベッドで寝られるぜ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01106_9010005")

-- ▼直接出力
lookat_delay_weight(Actor002,0.8,0,0.5,0,0.8)
keep_delay_ik_lookat(Actor002,Actor005,"J_Head",0.8)
-- ▲直接出力

	--★★ディナタン★★:そっか。マルディサントは<br>ここに住み込みで働いてたんだっけ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_9010006")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:ねえ、マルディサントの部屋、見せてよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_9010007")

-- ▼直接出力
lookat_delay_weight(Actor005,0.8,0,0.5,0,0.8)
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",0.8)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Surp")
	change_face(Actor005,"Surprise")

	--★★マルディサント★★:ハァ！？
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01106_9010008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Normal")

	--★★マルディサント★★:まあ、いいけどよ。たいしたモンねえぜ？<br>荷物はあらかた学園に持ってっちまってるし
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01106_9010009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:別にいいよ、それで<br>さ、行こ行こ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_9010010")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
off_active(Actor002)
off_active(Actor005)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Smile")

	--★★ガウェイン★★:モルガン先生<br>別荘のなか、見て回っていいっすか？
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01106_9010011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
	change_face(Actor007,"Smile")

	--★★モルガン★★:もちろんよ
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01106_9010012")

	change_face(Actor006,"Laugh")

	--★★ガウェイン★★:よっしゃ<br>行こうぜ、トリスタン！
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01106_9010013")

	PlayAction(Actor009,"to  Std_No")
	change_face(Actor009,"Surprise")

	--★★トリスタン★★:なんでボクを誘うの？<br>ボクはいいよ、子供じゃあるまいし
	Talk(Actor009,"CHRNAME_TRISTAN","speech","L","MA_01106_9010014")

	change_face(Actor006,"Smile")

	--★★ガウェイン★★:つれねーこと言うなって<br>いいから行こうぜ
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01106_9010015")

	change_face(Actor004,"Smile")

	--★★ギネヴィア★★:あっ、おもしろそー！<br>わたしたちも行こう、お姉ちゃん
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01106_9010016")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
	change_face(Actor008,"Laugh")

	--★★ギネマウア★★:はいはい
	Talk(Actor008,"CHRNAME_GWENHWYMAWR","speech","L","MA_01106_9010017")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
off_active(Actor004)
off_active(Actor006)
off_active(Actor008)
off_active(Actor009)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★モルガン★★:ふふっ、賑やかになって嬉しい<br>昔を思い出すわ
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01106_9010018")


	--★★ノワール★★:昔？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_9010019")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
	change_face(Actor007,"Normal")

	--★★モルガン★★:昔はね、マルディサント以外にも<br>この別荘にたくさんの子が住んでいたの
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01106_9010020")


	--★★ランスロット★★:その方たちは今？
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01106_9010021")

	play_head_motion(Actor007, "No", 0.3, 1.0, false)
	change_face(Actor007,"Sad")

	--★★モルガン★★:何人かの使用人の子を残して<br>みんな出て行っちゃったわ
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01106_9010022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ランスロット★★:…失礼
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01106_9010023")

	change_face(Actor007,"Normal")

	--★★モルガン★★:いいのよ<br>私が至らなかったせいだから
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01106_9010024")


	--★★モルガン★★:ねえ<br>ふたりは幼馴染なんでしょう？
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01106_9010025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ああ。俺とランスロットと父さんとで<br>よく剣術の訓練をしてた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_9010026")

	PlayAction(Actor007,"to  Std_Talk")
	change_face(Actor007,"Smile")

	--★★モルガン★★:だったら兄弟みたいなものね<br>素敵だわ
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01106_9010027")

	change_face(Actor007,"Normal")

	--★★モルガン★★:ノワールくんにランスロット<br>人生の先輩として、ひとつアドバイスがあるわ
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01106_9010028")

	change_face(Actor003,"Normal")

	--★★ランスロット★★:…なんだろうか
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01106_9010029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルガン★★:お互いの手を離してはダメよ
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01106_9010030")

	change_face(Actor007,"Sad")

	--★★モルガン★★:もしも離れてしまったとき<br>次にまた会える保証はないのだから
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01106_9010031")

	change_face(Actor007,"Smile")

	--★★モルガン★★:私の話はおしまい<br>さ、屋敷の中に入りましょう
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01106_9010032")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
	change_face(Actor007,"Normal")

	--★★モルガン★★:使用人の子たちに<br>晩ご飯を用意させるわ
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01106_9010033")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111031)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor009")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
