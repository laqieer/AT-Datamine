-- このluaスクリプトは、CO_101028_0903.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",95,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	Camera002 = SetTemplate("Actor002",220,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	Camera004 = SetTemplate("Actor004",300,CharaPos114011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_005)
	Camera005 = SetTemplate("Actor005",344,CharaPos114011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_006)
	Camera006 = SetTemplate("Actor006",165,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
hotdog = setup_prop_object(10102001)
hotdog_offset = {0,0,0,0,0,0}
off_active(hotdog)
load_image("104000080", "content_still_10400008_image", "104000080_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Reconnaissance")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Antagonism")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Acoustic")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401012","001","401012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_2DOnly("101036","001","101036001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:試験だからってそんなに緊張しなくてもいいだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030002")

-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:そう言われても男の子っぽい振る舞いはダメと言われているし
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラハッド★★:どこかから姉上に見られていると思うとどうしてもな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:心配しなくてもいつもどおりにしてれば大丈夫さ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:い、いつもどおりと言ってもだな…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030006")

-- ▼直接出力
ShowImageItem("104000080")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:胸のそのアクセサリー…<br>俺がこのあいだプレゼントしたヤツだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030009")

-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力

	--★★ガラハッド★★:へ、変だろうか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030010")

-- ▼直接出力
HideImageItem()
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★ガラハッド★★:デデデデ、デートはおめかしするものだろう？だだだだ、だったらお気に入りを身に着けて…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030012")

	PlayAction(Actor002,"to  Std_Surp")

	--★★ガラハッド★★:あ、あーっ！お気に入りといってもだな、誤解しないでくれ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:ぼぼぼぼ、僕はこれしか持っていないわけでだから仕方なく身に着けるしか…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030014")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:いや違う僕はなにを言っているんだいいかノワール気を悪くするな仕方なくというのは言葉のアヤ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101028_09030017","CO_101028_09030018","CO_101028_09030019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:すごく似合ってるよかわいいと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030021")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:かっ！？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030022")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:ぼ、僕を愚弄する気か！？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030023")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:い、いや、待てよ？今、僕は騎士の恰好をしていない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030024")

	change_face(Actor002,"Shy")

	--★★ガラハッド★★:ということは愚弄されたわけではないのか？だとするとこの感情の高まりはなんなんだ！？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030025")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:落ち着いて落ち着いて、ガラハッド
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030026")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうした？突然なにを焦ってるんだ、ガラハッド
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030028")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:焦ってなどいない！お前に怒っているのだ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030029")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんで俺に？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030031")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:フィエナの最終試験に手を抜くわけにはいかないよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:そういうことだ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030034")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:昨晩、寝ずに考えたんだベストを尽くすにはどうすればいいかを！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030035")

	goto Block1end

::Block1end::
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:だったら俺も本気でエスコートしないとな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030037")

-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:お、お手柔らかに頼む…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030038")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Camera001 = setup_small_camera_resetting(Actor001,CharaPos114011_01_005,CameraPos114011_01_005)
Camera002 = setup_small_camera_resetting(Actor002,CharaPos114011_01_008,CameraPos114011_01_008)
turn_chara(Actor001,92,0)
turn_chara(Actor002,80,0)
lookat_weight_reset(Actor001)
lookat_weight_reset(Actor002)
PlayActionDirect(Actor001,"to  Std_Worry")
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(CHARA_IN_WAIT + 0.5)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
turn_chara(Actor001,344,0)
turn_chara(Actor002,180,0)
PlayActionDirect(Actor001,"to EatIdle")
PlayActionDirect(Actor002,"to EatIdle")
on_active(hotdog)
on_parent(hotdog,Actor002, "Loc_weapon_constrint_R", hotdog_offset)
wait_time(CHARA_IN_WAIT + 0.5)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
setup_small_camera_start(Camera002)
change_face(Actor002,"Smile")
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Camera001 = setup_small_camera_resetting(Actor001,CharaPos114011_01_002,CameraPos114011_01_002)
Camera002 = setup_small_camera_resetting(Actor002,CharaPos114011_01_001,CameraPos114011_01_001)
turn_chara(Actor001,138,0)
turn_chara(Actor002,110,0)
off_parent(hotdog)
off_active(hotdog)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor001,0.55,0.1,0.8,0.2)
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
Appear(Actor004)
Appear(Actor005)
Appear(Actor006)
wait_time(CHARA_IN_WAIT + 0.5)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)

-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:だいぶ肩の力<br>抜けてきたんじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030043")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:そうだろうか<br>姉上のレッスンのたまものだな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030044")

-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:こんなふうに日常を過ごすのも悪くない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",1)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_女1", "苦しみ")
-- ▲直接出力

	--★★市民（女）★★:や、やめてください謝りますから、妹に乱暴しないで
	Talk(Actor004,"NPCNAME_0290","speech","N","CO_101028_09030047")

-- ▼直接出力
bgm_play("BGM_ADV_Reconnaissance")
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("山賊", "否定")
-- ▲直接出力

	--★★山賊★★:先にぶつかってきたのはこのガキだお返しさせてもらわなきゃ、オレの気が済まねえ
	Talk(Actor006,"NPCNAME_0291","speech","N","CO_101028_09030049")

	PlayAction(Actor005,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("子供_女1", "悲しみ")
-- ▲直接出力

	--★★子供（女）★★:うわああああん！
	Talk(Actor005,"NPCNAME_0274","speech","N","CO_101028_09030050")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ケンカか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030051")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:なんにしても大の大人が女の子に乱暴なんて、見過ごせない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030052")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:しかし…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030053")

	open_select_window_tag(Actor001,"Normal","CO_101028_09030055","CO_101028_09030056")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今は最終試験の真っ最中男の子っぽい振る舞いは禁止
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030058")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:街のなかでのケンカなんてもってのほか…なんて考えてるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030059")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:………
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030060")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:お前がフィエナを大切な存在だと思っていてその言いつけを守りたい気持ちはわかる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030061")

	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、お前の騎士道ってなんだ、ガラハッド？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030062")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:あの子たちのことを見て見ぬふりをしたとしてそれでフィエナが喜ぶと思うか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030063")

-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:僕の、騎士道…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030065")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor006,"J_Head",0.3)
wait_time(0.6)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:僕はみんなを守る！弱き者たちを守る！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030067")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガラハッド、ここは俺がやる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030069")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:いや、ノワール<br>僕にやらせてくれ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030070")

	change_face(Actor002,"Anger")

	--★★ガラハッド★★:あの男の悪辣な所業、許しておけない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030071")

-- ▼直接出力
wait_time(0.2)
keep_delay_ik_lookat(Actor002,Actor006,"J_Head",0.3)
wait_time(0.5)
-- ▲直接出力
	goto Block2end

::Block2end::
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor006,"to Wlk")
turn_chara(Actor006,210,0.4)
wait_time(0.4)
PlayActionDirect(Actor006,"to Std_Loop")
keep_delay_ik_lookat(Actor001,Actor006,"J_Head",1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("山賊", "怒り")
-- ▲直接出力

	--★★山賊★★:なんだあ、ガキ…？
	Talk(Actor006,"NPCNAME_0291","speech","N","CO_101028_09030073")

-- ▼直接出力
PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:ご婦人や少女には手を出すな！ここは銀卓騎士団ガラハッドが相手になる！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030074")

	PlayAction(Actor006,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("山賊", "激怒")
-- ▲直接出力

	--★★山賊★★:おめえに用はねえよ！邪魔だ、どいてろ！
	Talk(Actor006,"NPCNAME_0291","speech","N","CO_101028_09030076")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_CO_101028_0903_Accessory_Break")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:あっ！？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030078")


	--★★山賊★★:おめえみてえなチンチクリンが騎士だあ？冗談も休み休み言え！
	Talk(Actor006,"NPCNAME_0291","speech","N","CO_101028_09030079")

-- ▼直接出力
PlayPartVoice("山賊", "喜び")
-- ▲直接出力

	--★★山賊★★:色気づいて似合わねえアクセサリー付けてよ！ヒャハハハハハ！！
	Talk(Actor006,"NPCNAME_0291","speech","N","CO_101028_09030080")

-- ▼直接出力
PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★ガラハッド★★:似合わ…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030081")

	change_face(Actor001,"Normal")

	--★★ノワール★★:取り消せ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030083")

-- ▼直接出力
PlayPartVoice("山賊", "怒り")
-- ▲直接出力

	--★★山賊★★:あぁ？
	Talk(Actor006,"NPCNAME_0291","speech","N","CO_101028_09030084")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:ガラハッドほど自分の騎士道に誠実に向き合っている騎士はいない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030085")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:真の騎士へ吐いた暴言を今すぐ取り消せ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030086")

	PlayAction(Actor006,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("山賊", "笑い")
-- ▲直接出力

	--★★山賊★★:聞いたことねえか？一度吐いたツバってのは、飲み込めねえんだよ
	Talk(Actor006,"NPCNAME_0291","speech","N","CO_101028_09030088")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ならば、仕方ない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030089")

-- ▼直接出力
bgm_play("BGM_ADV_Antagonism")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:ガラハッド、手加減なしでいくぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030090")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:もとよりそのつもりだ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030091")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + 0.5)
se_play("SE_ADV_CO_101028_0903_Bandit_Bokoboko")
wait_time(2.0)
Hide(Actor006)
turn_lookat(Actor004,Actor002,0)
turn_lookat(Actor005,Actor002,0)
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
wait_time(CHARA_IN_WAIT + 0.5)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Area_Acoustic")
-- ▲直接出力

	--★★市民（女）★★:ありがとうございます、騎士様方！
	Talk(Actor004,"NPCNAME_0290","speech","N","CO_101028_09030093")

	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("子供_女1", "笑い")
-- ▲直接出力

	--★★子供（女）★★:お兄ちゃん、お姉ちゃんすごくすごくかっこよかった！
	Talk(Actor005,"NPCNAME_0274","speech","N","CO_101028_09030094")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:騎士として当然のことをしたまでふたりとも無事でよかった…あっ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030096")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ノワール、実は…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030098")

	PlayAction(Actor007,"to Greet_one")
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力

	--★★フィエナ2★★:はいはーい、お疲れさま！
	Talk(Actor007,"CHRNAME_VIENA","speech","L","CO_101028_09030100")

-- ▼直接出力
EntryWalk(Actor003,Camera003,EntryData114011_01_04,CameraAssetBundleName114011_01,CameraPos114011_01_104)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1)
wait_time(0.2)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
keep_delay_ik_lookat(Actor004,Actor003,"J_Head",1)
keep_delay_ik_lookat(Actor005,Actor003,"J_Head",1)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:姉上！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030101")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:すみませんルール違反をしてしまいました
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030102")

-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:うんうん、ぜ～んぶ見てたよ！ふたりのデートの様子、ばっちりね
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_09030103")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★フィエナ★★:と、いうことで！審査ののち、試験の合否発表を行うから！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_09030104")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:この場では発表しないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_09030105")

-- ▼直接出力
PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力

	--★★フィエナ★★:ノワール、わかってないなあ試験は結果発表のときが一番盛り上がるんだよ？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_09030106")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力

	--★★フィエナ★★:だから、時と場所が重要なの！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_09030107")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★ガラハッド★★:…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09030109")

-- ▼直接出力
local trustParam = set_communication_rankup("ガラハッド_コミュランク", "ガラハッド_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102001)
hotdog_offset = {0,0,0,0,0,0}
load_image_preload("104000080", "content_still_10400008_image", "104000080_StillImage")
preload_sound("BGM_ADV_Reconnaissance")
preload_sound("BGM_ADV_Antagonism")
preload_sound("BGM_Area_Acoustic")
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401012","001","401012001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401016","001","401016001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_2DOnly_Preload("101036","001","101036001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
