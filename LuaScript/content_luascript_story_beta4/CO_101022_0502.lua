-- このluaスクリプトは、CO_101022_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_007)
	Camera003 = SetTemplate("Actor004",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor004,"J_Head")
lookat_weight(Actor001,0.8,0.5,0.6,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor001,"J_Head")
lookat_weight(Actor004,0.8,0.5,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
load_image("103050010", "content_still_10305001_image", "103050010_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101022","001","101022001")
	Actor004 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クラリス", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クラリス★★:こんにちは～ノワールくん
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020002")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:こんにちは俺を呼んでるって話だったけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020003")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クラリス", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クラリス★★:はい～お礼をしたくって
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:お礼？なんの？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020005")

-- ▼直接出力
PlayPartVoice("クラリス", "肯定3")
-- ▲直接出力

	--★★クラリス★★:この前、わたしのためのお薬を持ってきてくださったお礼です～
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020006")

	PlayAction(Actor004,"to  Std_Talk")

	--★★クラリス★★:こちらをどうぞ。わたしが育てたハーブです切り傷擦り傷によく効くんですよ
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ありがとうなんか悪いな。そんなつもりじゃなかったのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020009")

	change_face(Actor004,"Smile")

	--★★クラリス★★:いいえいいえ～。ノワールくんがお薬届けに来てくれて助かりましたから
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020010")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★クラリス★★:いつもならケガしちゃったときはここで育てたハーブで治すんですけど
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クラリス", "照れ")
-- ▲直接出力

	--★★クラリス★★:あのときは切らしちゃってて…えへへ
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020012")


	--★★ノワール★★:そんなにしょっちゅうケガしてるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020013")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Surprise")

	--★★クラリス★★:い、いえいえ～そんなことはないですよ～？
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クラリス", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Shy")

	--★★クラリス★★:ただちょ～っと棚にぶつかったりつまづいちゃったりすることが多いだけです
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020015")


	--★★ノワール★★:（しょっちゅうなんだな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101022_05020016")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:それはそうと、あのときのケガは？もう大丈夫なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020017")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クラリス", "肯定")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クラリス★★:はい～ノワールくんのお薬のお陰です～
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020018")


	--★★クラリス★★:今ちょっと、別のところが痛んでますけどあのときの怪我はもう全然大丈夫です～！
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020019")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いやそれは大丈夫って言わないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだったらまた薬を貰ってこようか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020021")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★クラリス★★:あ、大丈夫ですよ～今回はもう、ハーブで手当しましたから～
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020022")

-- ▼直接出力
PlayPartVoice("クラリス", "照れ")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クラリス★★:モルくんには安静にしてろって怒られちゃいましたけど…えへへ
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad01")
	change_face(Actor004,"Normal")

	--★★クラリス★★:ダメですね～わたしモルくんのキラーズなのに怒られてばっかりで…
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020024")

-- ▼直接出力
PlayPartVoice("クラリス", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★クラリス★★:もっと、頑張らないと…
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020026")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
  --エフェクト開始
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("103050010", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★モルドレッド2★★:本当はあいつ以上に不幸なヤツはいねえんだよ俺は少なくとも知らねえ
	Talk(Actor003,"CHRNAME_MORDRED","simple","N","CO_101022_05020028")


	--★★モルドレッド2★★:それなのにあいつは頑張っていつもみんなの前では笑顔でいやがる
	Talk(Actor003,"CHRNAME_MORDRED","simple","N","CO_101022_05020029")


	--★★モルドレッド2★★:頑張る必要なんてねえのによ
	Talk(Actor003,"CHRNAME_MORDRED","simple","N","CO_101022_05020030")


	--★★モルドレッド2★★:俺はそれを知っていながらさらに頑張んなきゃならねえ道を選ばせちまった
	Talk(Actor003,"CHRNAME_MORDRED","simple","N","CO_101022_05020031")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
--エフェクト終了
hide_image() 
--スチル終了
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:なあ、クラリス
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020033")

-- ▼直接出力
PlayPartVoice("クラリス", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クラリス★★:はい～なんですか～？
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:クラリスは自分がモルドレッドとGSしたことについて、どう思ってるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クラリス", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★クラリス★★:え…？
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020037")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや、ほらクラリスって争いごとが苦手なんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020038")

	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、キラーズになったらそういうのは避けられないじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020039")

	change_face(Actor004,"Normal")

	--★★クラリス★★:…です
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020041")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020043")

	PlayAction(Actor004,"to  Std_Worry")

	--★★クラリス★★:いいんです、これで
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:クラリス？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020045")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クラリス", "肯定")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クラリス★★:わたしは、シアワセですモルくんのキラーズになれて
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020047")

	PlayAction(Actor004,"to  Std_Joy")

	--★★クラリス★★:だって、わたしのシアワセはモルくんのお役に立つことだから…
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020048")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:クラリス…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020049")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クラリス", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クラリス★★:本当ですよ～？
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020050")


	--★★クラリス★★:モルくんはわたしのことを要らないって言わないですから
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020051")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020053")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クラリス", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★クラリス★★:戦いとか、争いとか…みんなにしてほしくはないですけど
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020054")

	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Normal")

	--★★クラリス★★:モルくんのお役に立てるならわたし、頑張るって決めたんです
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020055")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力

	--★★クラリス★★:それがわたしの――
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020056")

-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド2★★:おい、クラリス<br>いつもの店の焼き菓子買って来た…
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","CO_101022_05020058")

-- ▼直接出力
 --首の動きをスムーズにするためEntrywalkをばらす
CloseTalkWindow()

local eeCamera = EntryData110101_01_07[1]
local startPos = EntryData110101_01_07[2] 
local goalPos = EntryData110101_01_07[3]  
local CameraTime1 = EntryData110101_01_07[4]
local CameraTime2 = EntryData110101_01_07[5]
local MoveTime = EntryData110101_01_07[6]
local TurnTime = EntryData110101_01_07[7]        

load_exclusive_camera(eeCamera ,CameraAssetBundleName110101_01, CameraPos110101_01_107, Actor002)
eeCamera.CopyOffset(Camera002)

--キャラを移動させる
on_active(Actor002)
set_pos(Actor002,startPos)
turn_lookat_position(Actor002,goalPos[1],goalPos[2],goalPos[3],0) --向きを行先に合わせる
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002, goalPos[1],goalPos[2],goalPos[3] ,MoveTime)
-- 俯瞰
on_camera(RndCamera090)

wait_time(CameraTime1)

on_camera(eeCamera)

while eeCamera.IsPositionAnimationPlayng() do
	coroutine.yield()
end

Camera002.SetSkipOffset()

if manager ~= nil then
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002) -- キャラカメラに変更
end

keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1)

PlayActionDirect(Actor002,"to Std_Loop")       --　モーションを基本立ちに設定して
turn_chara(Actor002, goalPos[4],TurnTime)          --　回転させる

--ここで首の命令を入れる
 -- lookat_delay_weight(Actor002,0.7,0.5,0.5,0.2,0.4)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.4)
wait_time(TurnTime)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:ぞ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_05020060")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("モルドレッド", "激怒")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Anger")

	--★★モルドレッド★★:なんでいるんだてめえ！！
	Talk(Actor002,"CHRNAME_MORDRED","speech","N","CO_101022_05020062")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101022_05020064","CO_101022_05020065")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたが俺に伝えてきたんだろクラリスが呼んでるって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020067")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:なんでまだいるんだってことだよ！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_05020068")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:仕方ないだろクラリスと話したかったんだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020069")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いつもの店ってなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020071")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:そこを拾うな！てめえにゃ関係ねーよ！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_05020072")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いやでも焼き菓子買ってきたって聞いちゃったし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020073")

	goto Block1end

::Block1end::
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クラリス", "肯定")
-- ▲直接出力

	--★★クラリス★★:おかえりなさい、モルくん～
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020075")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1)
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クラリス★★:いい匂いですね～<br>もしかして焼きたてですか～？
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020077")

	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:偶然、偶！然！時間がちょうどだったからな。偶然！！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_05020078")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クラリス", "喜び")
-- ▲直接出力

	--★★クラリス★★:うふふ～早く食べたいです～
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020079")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:怪我人は大人しく座ってろ今、取り皿持ってくっから
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_05020080")

-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",1)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★クラリス★★:ノワールくんも一緒に食べましょうね～
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","CO_101022_05020081")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？あ、ああ…（いいのか…？）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020082")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:残したらハンゴロシ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_05020084")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:はい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020085")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力

	--★★モルドレッド★★:オレが菓子並んで買ってきたことをバラしたらゼンゴロシ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_05020086")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:はい（並んで買ってきたのか…）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_05020087")

-- ▼直接出力
local trustParam = set_communication_rankup("モルドレッド_コミュランク", "モルドレッド_親密度")
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
load_image_preload("103050010", "content_still_10305001_image", "103050010_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101022","001","101022001")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
