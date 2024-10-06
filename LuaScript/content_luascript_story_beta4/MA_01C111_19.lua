-- このluaスクリプトは、MA_01C111_19.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_03","111013_03_h")
Include("content_adv_advsmall_111013_03","Template111013_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111013_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111013_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111013_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111013_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_008)
	InitializeTemplateRandomCamera111013_03()
	InitializeTemplate111013_03()
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111017)
	Actor001 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101044","001","101044001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101045","001","101045001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101046","001","101046001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01C111_191001")


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01C111_191002")


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01C111_191003")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス","悩む")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ルーシャス★★:隣人を疑いたくはないのだがな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_190002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス","悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ヴェルナルス★★:ルーシャス様。ご無理をなさらぬよう<br>先の戦いのキズがまだ癒えてはいないでしょう
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01C111_190003")

-- ▼直接出力
 --PlayPartVoice("ルーシャス","激怒")
-- ▲直接出力

	--★★ルーシャス★★:化け物どもは<br>貴様らの手足ではないのか
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_190005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
lookat_delay_weight_reset(Actor002,1)
 --PlayPartVoice("モーロノエー","挨拶")
-- ▲直接出力

	--★★モーロノエー★★:大いなる皇太子殿下は<br>民の隅々まで目を届かせることができて？
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_190007")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ルーシャス★★:…ローマ大帝国がそれをできていれば<br>分裂を繰り返したりはせぬな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_190008")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
set_rot(Actor004,{0,130,0})
 --PlayPartVoice("ヴェルナルス","怒り")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ヴェルナルス★★:アーサーについたバルバロイの軍勢…<br>貴様たちの支配下にはないと？
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01C111_190009")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("グリーテン","笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★グリーテン★★:めんどうくさいわね、ネア？
	Talk(Actor004,"CHRNAME_SISTERS_3","speech","L","MA_01C111_190011")

	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("グリートーネア","納得")
-- ▲直接出力

	--★★グリートーネア★★:ネアには難しいことはわかりませんけれど
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01C111_190013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
 --PlayPartVoice("ルーシャス","驚き")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:アーサーの所在は
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_190015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_rot(Actor004,{0,175,0})
 --PlayPartVoice("ヴェルナルス","肯定3")
-- ▲直接出力

	--★★ヴェルナルス★★:は。島南東の廃城をアバドンと名付け<br>そこに居を構えたようです
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01C111_190016")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス","納得")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ルーシャス★★:…あそこか<br>少々やっかいだな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_190017")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ヴェルナルス★★:このカレドニア城は<br>ログレスとアバドンとの合間に位置します
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01C111_190018")


	--★★ヴェルナルス★★:両軍が共闘し挟撃されることは<br>ないと思われますが
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01C111_190019")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ヴェルナルス★★:断続的に両軍との戦いが起こることは<br>確実でしょう
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01C111_190020")


	--★★ヴェルナルス★★:一度ロンディニウムに<br>居を戻すこともお考えになられては？
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01C111_190021")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス","否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:却下だ<br>ローマ皇太子に後退の二文字はない
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_190022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ルーシャス★★:それに聖杯の反応は島の東側なのだろう？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_190024")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モーロノエー","肯定")
-- ▲直接出力

	--★★モーロノエー★★:そうね<br>まだおぼろげではあるけれど
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_190025")


	--★★モーロノエー★★:聖杯はこの島の東側に出現する<br>それは間違いないと思うわ
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_190026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ルーシャス","肯定")
-- ▲直接出力

	--★★ルーシャス★★:であれば<br>ロンディニウムまで退くことは
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_190027")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ルーシャス★★:アーサーに聖杯を明け渡すと<br>言っているようなものではないか
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_190028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("グリートン","肯定3")
-- ▲直接出力

	--★★グリートン★★:勝機は、あります？
	Talk(Actor006,"CHRNAME_SISTERS_5","speech","L","MA_01C111_190029")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
 --PlayPartVoice("ルーシャス","笑い")
-- ▲直接出力

	--★★ルーシャス★★:これはログレスを負かす戦いでも<br>アーサーを討つための戦いでもない
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_190030")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
 --PlayPartVoice("モーロノエー","肯定3")
-- ▲直接出力

	--★★モーロノエー★★:ではなんのための？
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_190031")

-- ▼直接出力
 --PlayPartVoice("ルーシャス","激怒")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ルーシャス★★:きゃつらの過ちを明らかにするためだ<br>それが成せるならば余の身など
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_190032")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス","悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ヴェルナルス★★:…ですが盤面の駒の大半は<br>アーサーの手中です
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01C111_190034")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モーロノエー","肯定2")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★モーロノエー★★:計算が狂った、なんて負け惜しみ<br>吐かないでいただきたいものね
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_190035")

-- ▼直接出力
 --PlayPartVoice("ルーシャス","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ルーシャス★★:クッククク…
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_190036")

-- ▼直接出力
 --PlayPartVoice("モーロノエー","笑い")
-- ▲直接出力

	--★★モーロノエー★★:フッフフフ…♪
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_190037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ルーシャス","気合い")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ルーシャス★★:元より博打であったわ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_190038")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(111017)
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101044","001","101044001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101045","001","101045001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101046","001","101046001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111013_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
