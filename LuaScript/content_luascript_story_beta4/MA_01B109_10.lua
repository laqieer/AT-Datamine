-- このluaスクリプトは、MA_01B109_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera002 = SetTemplate("Actor002",334,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
set_enable_auto_lookat_all(true)
Hide(Actor004)
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Speculation")
-- ▲直接出力
-- ▼直接出力
-- 背景移動回転スケール
local bg = get_object("BG")
set_pos(bg,{-10,0,10})

-- 固定モブ移動回転スケール
local pro = get_object("Pro_1101_45")
set_pos(pro,{-10,0,10})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115114)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "苦しみ")
-- ▲直接出力

	--★★トリスタン★★:頭が痛いね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01B109_100002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "肯定3")
-- ▲直接出力

	--★★イゾルデ★★:円卓の騎士がお使いなんてね
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01B109_100003")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:すみません…人手が足りなくて
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B109_100004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★トリスタン★★:違うよ。頭痛の種は
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01B109_100005")


	--★★トリスタン★★:ズタズタになった騎士たちへの医療品を<br>買い込まなきゃいけないのもそうだけどさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01B109_100006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:なにより留学生の裏切りを見通せなかった…<br>ボクに対してだよ。情けないね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01B109_100007")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★イゾルデ★★:学園を見張る役割とはいえね<br>予想できたとしても手は出せなかったでしょう
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01B109_100009")


	--★★イゾルデ★★:ローマ皇太子殿下に無礼を働くわけにもいかない<br>魔女と組まれていたのでは未然の妨害も困難…
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01B109_100010")

	change_face(Actor003,"Normal")

	--★★イゾルデ★★:今はむしろ継承者のGSが果たされ<br>一時的にでも危機を乗り越えたことを喜ぶべきよ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01B109_100011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.2)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:それは嬉しい出来事だけどね、ディナタン？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01B109_100013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:ええ。もちろん
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B109_100015")

-- ▼直接出力
 --PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★イゾルデ★★:ディナタン<br>お前も治療される側でしょう
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01B109_100016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ディナタン★★:…なんか、動いていたくて
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B109_100017")

	PlayAction(Actor003,"to  Std_No")

	--★★イゾルデ★★:………傷を広げないことね
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01B109_100018")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
show_image("101010140", 0.0, 0.0, 0.0)
set_scale_image(20,20)
turn(Actor002,0,222,0,0)
Appear(Actor004)
Appear(Actor005)
set_enable_auto_lookat_all(false)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★フィエナ★★:──ディナタン………？
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","MA_01B109_100020")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
hide_image(0.0)

bow_01 = set_object("content_weapon_105010001", "weapon_model_105010001", true)
weapon_offset = {0,0,0,0,0,0}
on_parent(bow_01,Actor002, "Loc_weapon_constrint_L",weapon_offset)
set_animationbattlecontroller(Actor002, 8, false)
PlayActionDirect(Actor002,"ToIdle")

wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Speculation")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:フィエナ！？<br>どうしたの、その怪我…！？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B109_100022")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★イゾルデ★★:…ガラハッド<br>コルベニック城でお別れしたと聞いたけれど
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01B109_100023")

-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力
-- ▼直接出力
 --bow_01 = set_object("content_weapon_105010001", "weapon_model_105010001", true)
-- ▲直接出力
-- ▼直接出力
 --weapon_offset = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
 --on_parent(bow_01,Actor002, "Loc_weapon_constrint_R",weapon_offset)
-- ▲直接出力
-- ▼直接出力
 --set_animationbattlecontroller(Actor002, 8, false)
-- ▲直接出力
-- ▼直接出力
 --PlayActionDirect(Actor002,"ToIdle")
-- ▲直接出力
	PlayAction(Actor005,"to  Std_No")
	change_face(Actor005,"Anger")

	--★★ガラハッド★★:頼む、姉上を…介抱してやってくれ<br>ガラハッドはいい、姉上を………！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_100024")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★トリスタン★★:はい。動かないで
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01B109_100025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★トリスタン★★:キミの眉間を射抜けるよ<br>いつでもね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01B109_100027")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力

	--★★ディナタン★★:どうして、トリスタン卿…！？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B109_100028")

	PlayAction(Actor005,"to  Std_Surp")

	--★★ガラハッド★★:と、突然の来訪、その無礼は詫びる…！<br>だが…どうか、学園に──…
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_100029")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:再留学をご希望かな？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01B109_100030")

-- ▼直接出力
--フィエナ,CHRNAME_VIENA @名前変更
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★フィエナ★★:アーサー王に会わせて…！<br>伝えなきゃならないことが…あるの
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_100031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "納得")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★トリスタン★★:なるほどタダゴトじゃなさそうだ<br>面倒事を持ち込みそうな雰囲気がぷんぷんするよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01B109_100032")

	PlayAction(Actor005,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "激怒")
-- ▲直接出力

	--★★ガラハッド★★:ブリテンやログレスに関わるコトだ…！！<br>ガラハッドらは敵ではない！！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_100033")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★イゾルデ★★:群衆の皆々様、ご心配なく<br>キャメロット的面接であるとご認識を
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01B109_100035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★トリスタン★★:信じさせてみなよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01B109_100037")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン★★:いまのボクはあいにくだけど<br>「留学生疑うべし」って感じなんだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01B109_100038")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:それに学園はいま結構タイヘンでね<br>未知の不穏分子を受け入れるほど寛容じゃないよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01B109_100039")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:今日のところは、お引き取りを
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01B109_100041")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "落胆")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ガラハッド★★:………もう、どこへも──
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_100042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★トリスタン★★:謁見のアポなら取り次ぐよ<br>結果は追って連絡させていただきます
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01B109_100043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力

	--★★ガラハッド★★:…帰れない、もう…どこへも
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_100044")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_IN_OUT)
show_image("101010140_2", 0.0, 0.0, 0.0)
set_scale_image(20,20)
se_play("SE_ADV_MA_01B109_10_Fall")
wait_time(1.4)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★フィエナ★★:ガラハッド！？
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_100046")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Anger")

	--★★ディナタン★★:…が、学園に運びます…！<br>騎士の治療はそれが一番早いはずです
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B109_100048")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★イゾルデ★★:どう？トリスタン
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01B109_100049")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:…頭が痛いね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01B109_100051")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
preload_sound("BGM_ADV_Speculation")
	InitializeLoad_Preload()
	load_area_scene_preload(115114)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
