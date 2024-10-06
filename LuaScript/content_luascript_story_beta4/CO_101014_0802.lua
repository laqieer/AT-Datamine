-- このluaスクリプトは、CO_101014_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",-90,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera004 = SetTemplate("Actor004",-13,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_017_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101010111)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401025","001","401025001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401030","001","401030001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_2DOnly("101009","001","101009001")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("貴族_男1", "肯定2")
-- ▲直接出力

	--★★貴族（男）②★★:民たちの不安は日増しに強まるばかりです<br>生贄を捧げ、ドラゴンの怒りを鎮めねば
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_08020002")

-- ▼直接出力
PlayPartVoiceDirect("王様","0019")
-- ▲直接出力

	--★★汎用王様★★:ふうむ…<br>しかしだな…
	Talk(Actor005,"NPCNAME_0292","speech","N","CO_101014_08020003")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★貴族（男）②★★:姫を大事に思われるお気持ちは<br>私めも理解しております
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_08020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★貴族（男）②★★:しかし、民のことを考えれば<br>もはや一刻の猶予もございません。ご決断を！
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_08020005")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0015")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★ノワール2D★★:いもしない巨大なドラゴンに<br>生贄なんて捧げても意味はないだろう
	Talk(Actor006,"CHRNAME_NOIR","speech","L","CO_101014_08020007")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("貴族_男1", "怒り")
-- ▲直接出力

	--★★貴族（男）②★★:なんだと！？
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_08020008")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,0.5, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Appear(Actor001)
Appear(Actor002)
Appear(Actor003)
turn_chara(Actor004, 45,0)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME )
setup_small_camera_start()
fadein(CHARA_IN_OUT)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("貴族_男1","0010")
-- ▲直接出力

	--★★貴族（男）②★★:これはこれは…円卓の騎士の皆さま<br>突然現れて異なことをおっしゃる
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_08020010")


	--★★貴族（男）②★★:現に我が領地はその巨大ドラゴンに<br>一度滅ぼされかけたのですぞ？
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_08020011")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0007")
-- ▲直接出力

	--★★トリスタン★★:相変わらず上手だね<br>お芝居がさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_08020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("貴族_男1", "驚き")
-- ▲直接出力

	--★★貴族（男）②★★:し、芝居？<br>なにを…
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_08020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0002")
-- ▲直接出力

	--★★トリスタン★★:ところでさ<br>ボクは賛成だよ、生贄の件
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_08020014")

	open_select_window_tag(Actor001,"Normal","CO_101014_08020016","CO_101014_08020017")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:トリスタン、お前！<br>なにを言ってるんだ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_08020019")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ドラゴンなんていないって言ったのは<br>お前じゃないか。なのに生贄って…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_08020020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★トリスタン★★:うるさいな<br>ボクに考えがあるんだ。黙っててよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_08020021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:トリスタン<br>なにか考えがあるんだな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_08020023")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.2)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★トリスタン★★:へえ<br>わかってきたじゃない、ボクのこと
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_08020024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そりゃあ<br>これだけ一緒にいればな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_08020025")

	change_face(Actor002,"Sad")

	--★★トリスタン★★:ボクは別に…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_08020026")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:別に一緒にいたかったわけじゃない<br>だろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_08020027")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:…正解
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_08020028")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:そのドラゴンの怒りを鎮められれば<br>しばらく町が襲われることはないわけでしょ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_08020030")


	--★★トリスタン★★:安心して町の復興作業を進められるじゃない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_08020031")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("貴族_男1", "笑い")
-- ▲直接出力

	--★★貴族（男）②★★:ほっほう！<br>円卓の騎士さまもこう言っておられます
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_08020032")

-- ▼直接出力
setup_small_camera_start()
lookat_delay_weight_reset(Actor004,1.0)
wait_time(0.2)
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,-35,0.4)
wait_time(0.4)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★貴族（男）②★★:姫様もこう仰ってました<br>民のためであればこの命、捧げるつもりだと
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_08020033")

	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("王様", "悲しみ")
-- ▲直接出力

	--★★汎用王様★★:しばし、考えさせてくれぬか…
	Talk(Actor005,"NPCNAME_0292","speech","N","CO_101014_08020034")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera004)
end
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("貴族_男1", "肯定")
-- ▲直接出力

	--★★貴族（男）②★★:承知いたしました<br>しかし、迷っている時間はありませぬぞ
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_08020035")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,0.5, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor004)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力

	--★★イゾルデ★★:お前は本当にいいわけ？<br>ドラゴンのウワサを本当に信じているの？
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_08020037")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("王様", "悩む")
-- ▲直接出力

	--★★汎用王様★★:正直申し上げて<br>自分の判断が正しいかどうかはわかりません
	Talk(Actor005,"NPCNAME_0292","speech","N","CO_101014_08020038")


	--★★汎用王様★★:ですが、この町に暮らす人々は<br>私の支えであり、私が守るべき民です
	Talk(Actor005,"NPCNAME_0292","speech","N","CO_101014_08020039")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("王様", "肯定")
-- ▲直接出力

	--★★汎用王様★★:私は皆の笑顔を守ってあげたい<br>皆の想いを信じたい…それだけなのです
	Talk(Actor005,"NPCNAME_0292","speech","N","CO_101014_08020040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101014_08020042","CO_101014_08020043")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:皆の想いを信じたい、か<br>それはとても素晴らしいことだと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_08020045")

	change_face(Actor001,"Normal")

	--★★ノワール★★:信じあう心って周りに伝播して<br>大きな力を生み出してくれるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_08020046")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:信じあう心…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_08020047")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:娘を犠牲にしてでも守るべきものだと？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_08020049")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("王様", "肯定3")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★汎用王様★★:生贄として求められるのが私であれば<br>思い悩むこともなかったのですが…
	Talk(Actor005,"NPCNAME_0292","speech","N","CO_101014_08020050")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:もし生贄を代われるとしたら<br>やるつもりはあるということでいいか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_08020051")

	change_face(Actor005,"Normal")

	--★★汎用王様★★:領民の行く末は気になりますが<br>こうして円卓の騎士の方々が来て
	Talk(Actor005,"NPCNAME_0292","speech","N","CO_101014_08020052")

-- ▼直接出力
PlayPartVoice("王様", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★汎用王様★★:この地を気にかけていただけているのなら<br>領民のこともお願いできますし
	Talk(Actor005,"NPCNAME_0292","speech","N","CO_101014_08020053")

	goto Block2end

::Block2end::
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:やりようはいくらでもあると思うわよ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_08020055")

-- ▼直接出力
PlayPartVoice("王様", "驚き")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★汎用王様★★:それはいったい？
	Talk(Actor005,"NPCNAME_0292","speech","N","CO_101014_08020056")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:今は私たちに任せ<br>あなたはご息女のことを気にかけてあげて
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_08020057")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera005)
end
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("王様", "肯定3")
-- ▲直接出力

	--★★汎用王様★★:…そうですね
	Talk(Actor005,"NPCNAME_0292","speech","N","CO_101014_08020058")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,0.5, CHARA_IN_IN)
turn_chara(Actor003, 0,0)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor005)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:娘の代わりに生贄になれるならだって<br>怖くないのかな
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_08020059")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:怖いだろう<br>生贄だぞ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_08020060")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★トリスタン★★:そっちじゃない。人に裏切られること<br>あきらかにあの大臣はなにか企んでるよね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_08020061")

	change_face(Actor002,"Sad")

	--★★トリスタン★★:思い出すんだ、あのときのこと<br>ボクが誘拐されたときのこと
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_08020062")

-- ▼直接出力
voice_play("VO_101019_sp_0002_3")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★イゾルデ★★:トリスタン…
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_08020063")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ここまで露骨じゃなかったけどね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_08020064")

	change_face(Actor002,"Sad")

	--★★トリスタン★★:いや、あの頃のボクは幼なすぎて<br>わかっていなかっただけかな
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_08020065")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★トリスタン★★:なんにしても、見てみたくなった
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_08020066")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★トリスタン★★:最後まで人を信じた結果<br>どんな結末を迎えるのかさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_08020067")

-- ▼直接出力
local trustParam = set_communication_rankup("トリスタン_コミュランク", "トリスタン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
	InitializeLoad_Preload()
	load_duel_scene_preload(101010111)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401025","001","401025001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401030","001","401030001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_2DOnly_Preload("101009","001","101009001")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
